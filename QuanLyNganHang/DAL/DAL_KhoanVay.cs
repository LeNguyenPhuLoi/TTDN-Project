using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_KhoanVay
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_KhoanVay()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        // Lấy danh sách khoản vay
        public IQueryable LoadKhoanVay()
        {
            IQueryable ds = from kv in db.KHOANVAYs
                            select kv;
            return ds;
        }

        // Thêm khoản vay
        public bool ThemKhoanVay(ET_KhoanVay et)
        {
            bool flag = false;
            try
            {
                var exists = db.KHOANVAYs.Any(kv => kv.MAVAY == et.MAVAY);
                if (!exists)
                {
                    KHOANVAY kv = new KHOANVAY
                    {
                        MAVAY = et.MAVAY,
                        SOTIENVAY = et.SOTIENVAY,
                        NGAYVAY = et.NGAYVAY,
                        THOIHAN = et.THOIHAN,
                        TRANGTHAI = et.TRANGTHAI,
                        MAKH = et.MAKH,
                        MALAISUAT = et.MALAISUAT
                    };
                    db.KHOANVAYs.InsertOnSubmit(kv);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            return flag;
        }

        // Sửa khoản vay
        public bool CapNhatKhoanVay(ET_KhoanVay et)
        {
            bool flag = false;
            try
            {
                var kv = db.KHOANVAYs.Single(k => k.MAVAY == et.MAVAY);
                if (kv != null)
                {
                    kv.SOTIENVAY = et.SOTIENVAY;
                    kv.NGAYVAY = et.NGAYVAY;
                    kv.THOIHAN = et.THOIHAN;
                    kv.TRANGTHAI = et.TRANGTHAI;
                    kv.MAKH = et.MAKH;
                    kv.MALAISUAT = et.MALAISUAT;
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            return flag;
        }

        // Xóa khoản vay
        public bool XoaKhoanVay(ET_KhoanVay et)
        {
            bool flag = false;
            try
            {
                var xoa = from kv in db.KHOANVAYs
                          where kv.MAVAY == et.MAVAY
                          select kv;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.KHOANVAYs.DeleteOnSubmit(i);
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
            return flag;
        }
    }
}
