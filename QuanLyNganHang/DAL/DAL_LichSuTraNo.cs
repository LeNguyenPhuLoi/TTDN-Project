using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_LichSuTraNo_RP
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LichSuTraNo_RP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        // Lấy danh sách lịch sử trả nợ cho báo cáo
        public List<ET_LichSuTraNo_RP> LoadDSLSTN()
        {
            var query = from ls in db.LICHSUTRANOs
                        join kv in db.KHOANVAYs on ls.MAVAY equals kv.MAVAY
                        join kh in db.KHACHHANGs on kv.MAKH equals kh.MAKH
                        select new ET_LichSuTraNo_RP
                        {
                            MALICHSU = ls.MALICHSU,
                            MAVAY = ls.MAVAY,
                            MAKH = kv.MAKH,
                            TENKH = kh.TENKH,
                            TIENGOC = (decimal)ls.SOTIENGOC,
                            SOTIENTRA = (decimal)ls.SOTIENTRA,
                            NGAYTRA = Convert.ToDateTime(ls.NGAYTRA),
                            TRANGTHAI = kv.TRANGTHAI
                        };
            return query.ToList();
        }

        //Tim khoan vay
        public List<ET_LichSuTraNo_RP> TimRPLSTN(string keyword)
        {
            var search = from ls in db.LICHSUTRANOs
                         join kv in db.KHOANVAYs on ls.MAVAY equals kv.MAVAY
                         join kh in db.KHACHHANGs on kv.MAKH equals kh.MAKH
                         where ls.MALICHSU.Contains(keyword) ||
                               kv.MAVAY.Contains(keyword)
                         select new ET_LichSuTraNo_RP
                         {
                             MALICHSU = ls.MALICHSU,
                             MAVAY = ls.MAVAY,
                             MAKH = kv.MAKH,
                             TENKH = kh.TENKH,
                             TIENGOC = (decimal)ls.SOTIENGOC,
                             SOTIENTRA = (decimal)ls.SOTIENTRA,
                             NGAYTRA = Convert.ToDateTime(ls.NGAYTRA),
                             TRANGTHAI = kv.TRANGTHAI
                         };

            return search.ToList();
        }
    }


    public class DAL_LichSuTraNo
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LichSuTraNo()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        // Lấy danh sách lịch sử trả nợ
        public IQueryable LoadLichSuTraNo()
        {
            IQueryable ds = from ls in db.LICHSUTRANOs
                            select new
                            {
                                ls.MALICHSU,
                                ls.MAVAY,
                                ls.SOTIENGOC,
                                ls.SOTIENTRA,
                                ls.NGAYTRA
                            };
            return ds;
        }


        //lấy danh sách khoản vay
        public IQueryable LoadKhoanVay()
        {
            IQueryable ds = from kv in db.KHOANVAYs
                            select new
                            {
                                kv.MAVAY,
                                kv.SOTIENVAY,
                                kv.TONGTIEN,
                                kv.TIENTHANG,
                                kv.SOTHANG,
                                kv.TRANGTHAI
                            };
            return ds;
        }


        public bool ThemLichSuTraNo(ET_LichSuTraNo et, out string error)
        {
            error = string.Empty;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == et.MAVAY);
                if (khoanVay == null)
                {
                    error = "Không tìm thấy khoản vay.";
                    return false;
                }

                decimal tongPhaiTra = khoanVay.TONGTIEN ?? 0;
                decimal tienThang = khoanVay.TIENTHANG ?? 0;
                decimal tongDaTra = db.LICHSUTRANOs
                                      .Where(t => t.MAVAY == et.MAVAY)
                                      .Sum(t => (decimal?)t.SOTIENTRA) ?? 0;

                decimal soTienConLai = tongPhaiTra - tongDaTra;

                if (et.SOTIENTRA <= 0)
                {
                    error = "Số tiền trả phải lớn hơn 0.";
                    return false;
                }

                if (et.SOTIENTRA > soTienConLai)
                {
                    error = "Số tiền trả vượt quá số nợ còn lại.";
                    return false;
                }

                // Cho phép trả >= 1 tháng tiền
                if (et.SOTIENTRA < tienThang && et.SOTIENTRA < soTienConLai)
                {
                    error = $"Số tiền trả tối thiểu là {tienThang:N0} hoặc toàn bộ nợ còn lại.";
                    return false;
                }

                // Thêm lịch sử
                LICHSUTRANO ls = new LICHSUTRANO
                {
                    MALICHSU = et.MALICHSU,
                    MAVAY = et.MAVAY,
                    NGAYTRA = et.NGAYTRA,
                    SOTIENGOC = tienThang,
                    SOTIENTRA = et.SOTIENTRA
                };
                db.LICHSUTRANOs.InsertOnSubmit(ls);
                db.SubmitChanges();

                // Cập nhật trạng thái khoản vay
                CapNhatTrangThaiKhoanVay(khoanVay.MAVAY);

                return true;
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool XoaLichSuTraNo(ET_LichSuTraNo et, out string error)
        {
            error = string.Empty;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var ls = db.LICHSUTRANOs.SingleOrDefault(x => x.MALICHSU == et.MALICHSU);
                if (ls == null)
                {
                    error = "Không tìm thấy lịch sử trả nợ cần xóa.";
                    return false;
                }

                string maVay = ls.MAVAY;

                // Xóa bản ghi
                db.LICHSUTRANOs.DeleteOnSubmit(ls);
                db.SubmitChanges();

                // Cập nhật trạng thái khoản vay
                CapNhatTrangThaiKhoanVay(maVay);

                return true;
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool CapNhatLichSuTraNo(ET_LichSuTraNo et, out string error)
        {
            error = string.Empty;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                // Tìm lịch sử trả nợ cần cập nhật
                var ls = db.LICHSUTRANOs.SingleOrDefault(l => l.MALICHSU == et.MALICHSU);
                if (ls == null)
                {
                    error = "Không tìm thấy lịch sử trả nợ để cập nhật.";
                    return false;
                }

                var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == et.MAVAY);
                decimal tongPhaiTra = khoanVay.TONGTIEN ?? 0;
                decimal tienThang = khoanVay.TIENTHANG ?? 0;
                decimal tongDaTra = db.LICHSUTRANOs
                                      .Where(t => t.MAVAY == et.MAVAY)
                                      .Sum(t => (decimal?)t.SOTIENTRA) ?? 0;

                decimal soTienConLai = tongPhaiTra - tongDaTra;

                if (et.SOTIENTRA <= 0)
                {
                    error = "Số tiền trả phải lớn hơn 0.";
                    return false;
                }

                if (et.SOTIENTRA > soTienConLai)
                {
                    error = "Số tiền trả vượt quá số nợ còn lại.";
                    return false;
                }

                // Cho phép trả >= 1 tháng tiền
                if (et.SOTIENTRA < tienThang && et.SOTIENTRA < soTienConLai)
                {
                    error = $"Số tiền trả tối thiểu là {tienThang:N0} hoặc toàn bộ nợ còn lại.";
                    return false;
                }

                // Cập nhật dữ liệu mới
                ls.MAVAY = et.MAVAY;
                ls.SOTIENTRA = et.SOTIENTRA;
                ls.NGAYTRA = et.NGAYTRA;

                // Lưu thay đổi vào DB
                db.SubmitChanges();

                // Cập nhật trạng thái khoản vay bằng hàm chung
                CapNhatTrangThaiKhoanVay(et.MAVAY);

                return true;
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                return false;
            }
        }


        private void CapNhatTrangThaiKhoanVay(string maVay)
        {
            var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == maVay);
            if (khoanVay == null) return;

            decimal tongPhaiTra = khoanVay.TONGTIEN ?? 0;
            decimal tienThang = khoanVay.TIENTHANG ?? 0;
            decimal tongDaTra = db.LICHSUTRANOs
                                  .Where(t => t.MAVAY == maVay)
                                  .Sum(t => (decimal?)t.SOTIENTRA) ?? 0;

            decimal soTienConLai = tongPhaiTra - tongDaTra;

            if (soTienConLai <= 0)
            {
                khoanVay.TRANGTHAI = "Đã trả xong";
                khoanVay.SOTHANG = 0;
            }
            else
            {
                if (tongDaTra == 0)
                    khoanVay.TRANGTHAI = "Đang vay";
                else
                    khoanVay.TRANGTHAI = "Còn nợ";

                khoanVay.SOTHANG = tienThang > 0
                    ? (int)Math.Ceiling(soTienConLai / tienThang)
                    : 0;
            }

            db.SubmitChanges();
        }


        //Tìm kiếm áp dụng khuyến mãi
        DAL_ChuyenKhoan dl = new DAL_ChuyenKhoan();

        public IQueryable TimKiemLSTN(string keyword)
        {
            DateTime parsedDate;
            bool isDate = dl.IsValidSqlDate(keyword, out parsedDate);

            var ds = from ls in db.LICHSUTRANOs
                     where ls.MALICHSU.Contains(keyword) ||
                           ls.MAVAY.Contains(keyword) ||
                           ls.SOTIENGOC.ToString().Contains(keyword) ||
                           ls.SOTIENTRA.ToString().Contains(keyword) ||
                           (isDate && ls.NGAYTRA == parsedDate.Date)
                     select new
                     {
                         ls.MALICHSU,
                         ls.MAVAY,
                         ls.SOTIENGOC,
                         ls.SOTIENTRA,
                         ls.NGAYTRA
                     };
            return ds;
        }
    }
}
