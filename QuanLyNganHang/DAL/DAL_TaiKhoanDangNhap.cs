using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoanDangNhap
    {
        QLNHDataContext db = new QLNHDataContext();

        // Lấy danh sách tài khoản đăng nhập
        public IQueryable LayDSTaiKhoanDangNhap()
        {
            IQueryable ds = from tk in db.DANGNHAPs
                            select tk;
            return ds;
        }

        //Thêm Tai Khoản Đăng Nhập
        public bool ThemTaiKhoanDN(ET_DangNhap et)
        {
            bool flage = false;
            try
            {
                var amp = db.DANGNHAPs.Any(tk => tk.MADN == et.MADN);
                if (!amp) 
                {
                    DANGNHAP tk = new DANGNHAP
                    {
                        MADN = et.MADN,
                        PASS = et.PASS,
                        QUYEN = et.QUYEN,
                        MANV = et.MANV
                    };
                    db.DANGNHAPs.InsertOnSubmit(tk);
                    db.SubmitChanges();
                    flage = true;
                }
            }
            catch (Exception ex)
            {
                flage = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return flage;
        }

        //Sửa tài khoản đăng nhập
        public bool CapNhapTKDN(ET_DangNhap et)
        {
            bool flag = false;
            try
            {
                var capnhat = db.DANGNHAPs.Single(n => n.MADN == et.MADN);
                if (capnhat != null)
                {
                    capnhat.PASS = et.PASS;
                    capnhat.QUYEN = et.QUYEN;
                    capnhat.MANV = et.MANV;
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            finally
            {
                db.SubmitChanges();
            }
            return flag;
        }

        //xóa tai khoản đăng nhập
        public bool XoaTKDN(ET_DangNhap et)
        {
            bool flag = false;
            try
            {
                var xoa = from tk in db.DANGNHAPs
                          where tk.MADN == et.MADN
                          select tk;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.DANGNHAPs.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            finally { }
            return flag;
        }

    }
}
