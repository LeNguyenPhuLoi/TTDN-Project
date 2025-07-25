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


        // Thêm lịch sử trả nợ
        public bool ThemLichSuTraNo(ET_LichSuTraNo et, out string error)
        {
            error = string.Empty;
            try
            {
                // Kiểm tra khoản vay có tồn tại không
                var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == et.MAVAY);
                if (khoanVay == null)
                {
                    error = "Khoản vay không tồn tại.";
                    return false;
                }

                // Kiểm tra mã lịch sử đã tồn tại chưa
                if (db.LICHSUTRANOs.Any(lstn => lstn.MALICHSU == et.MALICHSU))
                {
                    error = "Mã lịch sử đã tồn tại.";
                    return false;
                }

                // Lấy tiền tháng từ khoản vay (sẽ dùng làm tiền gốc mỗi kỳ trả)
                decimal tienThang = khoanVay.TIENTHANG ?? 0;

                // Tính tổng số tiền đã trả trước đó
                decimal daTra = db.LICHSUTRANOs
                                  .Where(lstn => lstn.MAVAY == et.MAVAY)
                                  .Sum(lstn => (decimal?)lstn.SOTIENTRA) ?? 0;

                decimal tongPhaiTra = khoanVay.TONGTIEN ?? 0;

                // Kiểm tra trả vượt quá tổng cần trả
                if (daTra + et.SOTIENTRA > tongPhaiTra)
                {
                    error = "Số tiền trả vượt quá tổng tiền phải trả.";
                    return false;
                }

                // Thêm lịch sử trả nợ mới
                LICHSUTRANO ls = new LICHSUTRANO
                {
                    MALICHSU = et.MALICHSU,
                    MAVAY = et.MAVAY,
                    SOTIENGOC = tienThang,                // Gán từ TIENTHANG
                    SOTIENTRA = et.SOTIENTRA,            // Khách thực trả
                    NGAYTRA = et.NGAYTRA
                };
                db.LICHSUTRANOs.InsertOnSubmit(ls);

                // Cập nhật trạng thái và giảm số tháng còn lại
                decimal daTraMoi = daTra + et.SOTIENTRA;

                if (daTraMoi >= tongPhaiTra)
                {
                    khoanVay.TRANGTHAI = "Đã trả xong";
                    khoanVay.SOTHANG = 0;
                }
                else if (daTraMoi > 0)
                {
                    khoanVay.TRANGTHAI = "Còn nợ";
                    if (khoanVay.SOTHANG > 0)
                        khoanVay.SOTHANG -= 1;
                }

                db.SubmitChanges();
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
            try
            {
                // Tìm lịch sử trả nợ cần cập nhật
                var ls = db.LICHSUTRANOs.SingleOrDefault(l => l.MALICHSU == et.MALICHSU);
                if (ls == null)
                {
                    error = "Không tìm thấy lịch sử trả nợ để cập nhật.";
                    return false;
                }

                // Lấy khoản vay liên quan
                var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == et.MAVAY);
                if (khoanVay == null)
                {
                    error = "Khoản vay không tồn tại.";
                    return false;
                }

                // Cập nhật dữ liệu mới
                ls.MAVAY = et.MAVAY;
                ls.SOTIENTRA = et.SOTIENTRA;
                ls.NGAYTRA = et.NGAYTRA;

                // Tính lại tổng số tiền đã trả cho khoản vay này
                decimal tongDaTra = db.LICHSUTRANOs
                                      .Where(t => t.MAVAY == et.MAVAY)
                                      .Sum(t => (decimal?)t.SOTIENTRA) ?? 0;

                decimal tongPhaiTra = khoanVay.TONGTIEN ?? 0;

                // Cập nhật trạng thái
                if (tongDaTra >= tongPhaiTra)
                {
                    khoanVay.TRANGTHAI = "Đã trả xong";
                    khoanVay.SOTHANG = 0;
                }
                else if (tongDaTra > 0)
                {
                    khoanVay.TRANGTHAI = "Còn nợ";

                    decimal tienThang = khoanVay.TIENTHANG ?? 0;
                    if (tienThang > 0)
                    {
                        decimal soThangConLai = Math.Ceiling((tongPhaiTra - tongDaTra) / tienThang);
                        khoanVay.SOTHANG = (int)soThangConLai;
                    }
                }
                else
                {
                    khoanVay.TRANGTHAI = "Đang vay";
                }

                db.SubmitChanges();
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
            try
            {
                var ls = db.LICHSUTRANOs.SingleOrDefault(x => x.MALICHSU == et.MALICHSU);
                if (ls == null)
                {
                    error = "Không tìm thấy lịch sử trả nợ cần xóa.";
                    return false;
                }

                string maVay = ls.MAVAY;

                // Tiến hành xóa
                db.LICHSUTRANOs.DeleteOnSubmit(ls);
                db.SubmitChanges();

                // Cập nhật lại trạng thái khoản vay
                var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == maVay);
                if (khoanVay != null)
                {
                    decimal tongDaTra = db.LICHSUTRANOs
                                          .Where(t => t.MAVAY == maVay)
                                          .Sum(t => (decimal?)t.SOTIENTRA) ?? 0;

                    decimal tongPhaiTra = khoanVay.TONGTIEN ?? 0;
                    decimal tienThang = khoanVay.TIENTHANG ?? 0;

                    if (tongDaTra >= tongPhaiTra)
                    {
                        khoanVay.TRANGTHAI = "Đã trả xong";
                        khoanVay.SOTHANG = 0;
                    }
                    else if (tongDaTra > 0)
                    {
                        khoanVay.TRANGTHAI = "Còn nợ";
                        if (tienThang > 0)
                        {
                            decimal soThangConLai = Math.Ceiling((tongPhaiTra - tongDaTra) / tienThang);
                            khoanVay.SOTHANG = (int)soThangConLai;
                        }
                    }
                    else
                    {
                        khoanVay.TRANGTHAI = "Đang vay";
                        khoanVay.SOTHANG = (int)(tongPhaiTra / (tienThang == 0 ? 1 : tienThang));
                    }
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                return false;
            }
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
