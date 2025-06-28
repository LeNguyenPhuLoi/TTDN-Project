using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
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
                                kv.SOTIENLAI,
                                kv.NGAYVAY,
                                kv.THOIHAN,
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

                // Tính tổng số tiền đã trả
                decimal daTra = db.LICHSUTRANOs
                                  .Where(lstn => lstn.MAVAY == et.MAVAY)
                                  .Sum(lstn => (decimal?)lstn.SOTIENTRA) ?? 0;

                // Kiểm tra số tiền trả có vượt quá tổng tiền vay
                if (daTra + et.SOTIENTRA > et.TIENGOC)
                {
                    error = "Số tiền trả vượt quá số tiền vay.";
                    return false;
                }

                // Thêm lịch sử trả nợ
                LICHSUTRANO ls = new LICHSUTRANO
                {
                    MALICHSU = et.MALICHSU,
                    MAVAY = et.MAVAY,
                    SOTIENGOC = et.TIENGOC,
                    SOTIENTRA = et.SOTIENTRA,
                    NGAYTRA = et.NGAYTRA
                };
                db.LICHSUTRANOs.InsertOnSubmit(ls);

                decimal tongDaTraSauLanNay = daTra + et.SOTIENTRA;
                decimal tongVay = et.TIENGOC;

                // Cập nhật trạng thái khoản vay
                if (tongDaTraSauLanNay == tongVay)
                {
                    khoanVay.TRANGTHAI = "Đã trả xong";
                }
                else if (tongDaTraSauLanNay > 0 && tongDaTraSauLanNay < tongVay)
                {
                    khoanVay.TRANGTHAI = "Còn nợ";
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



        // Sửa lịch sử trả nợ
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

                // Cập nhật dữ liệu mới
                ls.MAVAY = et.MAVAY;
                ls.SOTIENTRA = et.SOTIENTRA;
                ls.NGAYTRA = et.NGAYTRA;

                // Sau khi sửa, cần cập nhật lại trạng thái khoản vay liên quan
                var khoanVay = db.KHOANVAYs.FirstOrDefault(kv => kv.MAVAY == et.MAVAY);
                if (khoanVay != null)
                {
                    // Tính lại tổng số tiền đã trả của khoản vay này
                    decimal daTraMoi = db.LICHSUTRANOs
                                        .Where(t => t.MAVAY == et.MAVAY)
                                        .Sum(t => (decimal?)t.SOTIENTRA) ?? 0;

                    decimal tongVay = khoanVay.SOTIENLAI ?? 0;

                    if (daTraMoi == tongVay)
                        khoanVay.TRANGTHAI = "Đã trả xong";
                    else if (daTraMoi > 0 && daTraMoi < tongVay)
                        khoanVay.TRANGTHAI = "Còn nợ";
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


        // Xóa lịch sử trả nợ
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

                    decimal tongVay = khoanVay.SOTIENVAY ?? 0;

                    if (tongDaTra == tongVay)
                        khoanVay.TRANGTHAI = "Đã trả xong";
                    else if (tongDaTra > 0 && tongDaTra < tongVay)
                        khoanVay.TRANGTHAI = "Còn nợ";
                    else
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

    }
}
