using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChuyenKhoan
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ChuyenKhoan()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lấy danh sách tài khoản
        public IQueryable LoadDSTK()
        {
            IQueryable ds = from tk in db.TAIKHOANs
                            select tk.MATK;
            return ds;
        }

        //Lấy ds chuyển khoản
        public IQueryable LayDSChuyenKhoan()
        {
            IQueryable ds = from ck in db.CHUYENKHOANs
                            select new
                            {
                                ck.MACK,
                                ck.NGAYCK,
                                ck.SOTIEN,
                                ck.MATKGUI,
                                ck.MATKNHAN,
                                ck.NOIDUNG
                            };
            return ds;
        }

        //Thêm chuyển khoản
        public bool ThemChuyenKhoan(ET_ChuyenKhoan et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            try
            {
                // Kiểm tra tài khoản gửi có tồn tại
                var taiKhoanGui = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MATKGUI);

                if (taiKhoanGui == null)
                {
                    error = "Tài khoản gửi không tồn tại.";
                    return false;
                }

                // Kiểm tra số dư tài khoản gửi
                if ((taiKhoanGui.SODU ?? 0) < et.SOTIEN)
                {
                    error = "Tài khoản gửi không đủ tiền.";
                    return false;
                }

                // Kiểm tra trùng mã chuyển khoản
                var amp = db.CHUYENKHOANs.Any(ck => ck.MACK == et.MACK);
                if (!amp)
                {
                    CHUYENKHOAN ck = new CHUYENKHOAN
                    {
                        MACK = et.MACK,
                        NGAYCK = et.NGAYCK,
                        SOTIEN = et.SOTIEN,
                        MATKGUI = et.MATKGUI,
                        MATKNHAN = et.MATKNHAN,
                        NOIDUNG = et.NOIDUNG
                    };

                    db.CHUYENKHOANs.InsertOnSubmit(ck);

                    // Trừ tiền tài khoản gửi
                    taiKhoanGui.SODU = (taiKhoanGui.SODU ?? 0) - et.SOTIEN;

                    // Cộng tiền tài khoản nhận nếu tồn tại
                    var taiKhoanNhan = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MATKNHAN);
                    if (taiKhoanNhan != null)
                    {
                        taiKhoanNhan.SODU = (taiKhoanNhan.SODU ?? 0) + (decimal)et.SOTIEN;
                    }

                    db.SubmitChanges();
                    flage = true;
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                flage = false;
            }
            return flage;
        }

        public bool CapNhapChuyenKhoan(ET_ChuyenKhoan et, out string error)
        {
            error = string.Empty;
            bool flag = false;

            try
            {
                var ck = db.CHUYENKHOANs.FirstOrDefault(n => n.MACK == et.MACK);
                if (ck == null)
                {
                    error = "Không tìm thấy giao dịch chuyển khoản.";
                    return false;
                }

                // Tài khoản cũ trước khi cập nhật
                var taiKhoanGuiCu = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == ck.MATKGUI);
                var taiKhoanNhanCu = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == ck.MATKNHAN);

                // ✅ Rollback đúng: hoàn lại tiền
                if (taiKhoanGuiCu != null)
                    taiKhoanGuiCu.SODU = (taiKhoanGuiCu.SODU ?? 0) + (ck.SOTIEN ?? 0);
                if (taiKhoanNhanCu != null)
                    taiKhoanNhanCu.SODU = (taiKhoanNhanCu.SODU ?? 0) - (ck.SOTIEN ?? 0);

                // Tài khoản mới
                var taiKhoanGuiMoi = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MATKGUI);
                var taiKhoanNhanMoi = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MATKNHAN);

                // Kiểm tra nếu không đủ tiền thì rollback lại rollback
                if (taiKhoanGuiMoi == null || (taiKhoanGuiMoi.SODU ?? 0) < et.SOTIEN)
                {
                    // ↩ Hoàn lại giao dịch cũ vì cập nhật thất bại
                    if (taiKhoanGuiCu != null)
                        taiKhoanGuiCu.SODU = (taiKhoanGuiCu.SODU ?? 0) - (ck.SOTIEN ?? 0);
                    if (taiKhoanNhanCu != null)
                        taiKhoanNhanCu.SODU = (taiKhoanNhanCu.SODU ?? 0) + (ck.SOTIEN ?? 0);

                    error = "Tài khoản gửi mới không đủ tiền để cập nhật giao dịch.";
                    return false;
                }

                // ✅ Thực hiện cập nhật số dư
                taiKhoanGuiMoi.SODU -= et.SOTIEN;
                taiKhoanNhanMoi.SODU += et.SOTIEN;

                // ✅ Cập nhật dữ liệu giao dịch
                ck.NGAYCK = et.NGAYCK;
                ck.SOTIEN = et.SOTIEN;
                ck.MATKGUI = et.MATKGUI;
                ck.MATKNHAN = et.MATKNHAN;
                ck.NOIDUNG = et.NOIDUNG;

                db.SubmitChanges();
                flag = true;
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                flag = false;
            }

            return flag;
        }


        //xóa chuyen khoản
        public bool XoaChuyenKhoan(ET_ChuyenKhoan et, out string error)
        {
            error = "";
            bool flag = false;
            try
            {
                var ck = db.CHUYENKHOANs.FirstOrDefault(c => c.MACK == et.MACK);
                if (ck == null)
                {
                    error = "Không tìm thấy giao dịch chuyển khoản.";
                    return false;
                }

                // Lấy tài khoản
                var taiKhoanGui = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == ck.MATKGUI);
                var taiKhoanNhan = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == ck.MATKNHAN);

                // Hoàn lại tiền
                if (taiKhoanGui != null)
                    taiKhoanGui.SODU = (taiKhoanGui.SODU ?? 0) + (decimal)(ck.SOTIEN ?? 0);

                if (taiKhoanNhan != null)
                    taiKhoanNhan.SODU = (taiKhoanNhan.SODU ?? 0) - (decimal)(ck.SOTIEN ?? 0);

                // Xóa giao dịch
                db.CHUYENKHOANs.DeleteOnSubmit(ck);
                db.SubmitChanges();
                flag = true;
            }
            catch (Exception ex)
            {
                error = "Lỗi khi xóa: " + ex.Message;
                flag = false;
            }

            return flag;
        }

        //Tìm kiếm chuyển khoản
        public IQueryable TimKiemChuyenKhoan(string keyword)
        {
            DateTime parsedDate;
            bool isDate = IsValidSqlDate(keyword, out parsedDate);

            var ds = from ck in db.CHUYENKHOANs
                     where ck.MACK.Contains(keyword)
                        || ck.NOIDUNG.Contains(keyword)
                        || ck.SOTIEN.ToString().Contains(keyword)
                        || ck.MATKGUI.Contains(keyword) 
                        || ck.MATKNHAN.Contains(keyword) 
                        || (isDate && ck.NGAYCK == parsedDate.Date)
                     select new
                     {
                         ck.MACK,
                         ck.NGAYCK,
                         ck.SOTIEN,
                         ck.MATKGUI,
                         ck.MATKNHAN,
                         ck.NOIDUNG
                     };
            return ds;
        }

        public bool IsValidSqlDate(string input, out DateTime result)
        {
            bool isValid = DateTime.TryParse(input, out result);
            return isValid && result >= new DateTime(1753, 1, 1) && result <= new DateTime(9999, 12, 31);
        }
    }
}
