using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

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

        //Lấy ds chuyển khoản
        public IQueryable LayDSChuyenKhoan()
        {
            IQueryable ds = from ck in db.CHUYENKHOANs
                            select ck;
            return ds;
        }

        //Thêm chuyển khoản
        public bool ThemChuyenKhoan(ET_ChuyenKhoan et)
        {
            bool flage = false;
            try
            {
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

        //Sửa chuyển khoản
        public bool CapNhapChuyenKhoan(ET_ChuyenKhoan et)
        {
            bool flag = false;
            try
            {
                var ck = db.CHUYENKHOANs.Single(n => n.MACK == et.MACK);
                if (ck != null)
                {
                    ck.NGAYCK = et.NGAYCK;
                    ck.SOTIEN = et.SOTIEN;
                    ck.MATKGUI = et.MATKGUI;
                    ck.MATKNHAN = et.MATKNHAN;
                    ck.NOIDUNG = et.NOIDUNG;
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

        //xóa chuyen khoản
        public bool XoaChuyenKhoan(ET_ChuyenKhoan et)
        {
            bool flag = false;
            try
            {
                var xoa = from ck in db.CHUYENKHOANs
                          where ck.MACK == et.MACK
                          select ck;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.CHUYENKHOANs.DeleteOnSubmit(i);
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
