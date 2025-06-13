using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ApDungKhuyenMai
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ApDungKhuyenMai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }
        // Lấy danh sách áp dụng khuyến mãi
        public IQueryable LoadKhuyenMai()
        {
            IQueryable ds = from adkm in db.APDUNGKHUYENMAIs
                            select adkm;
            return ds;
        }
        // Thêm Áp Dung khuyến mãi
        public bool ThemApDungKhuyenMai(ET_ApDungKhuyenMai et)
        {
            bool flag = false;
            try
            {
                var exists = db.APDUNGKHUYENMAIs.Any(adkm => adkm.MAKM == et.MAKM && adkm.MAKH == et.MAKM);
                if (!exists)
                {
                    APDUNGKHUYENMAI km = new APDUNGKHUYENMAI
                    {
                        MAKM = et.MAKM,
                        MAKH = et.MAKH,
                        MATK = et.MATK,
                        NGAYAPDUNG = et.NGAYAPDUNG
                    };
                    db.APDUNGKHUYENMAIs.InsertOnSubmit(km);
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
        // Sửa áp dụng khuyến mãi
        public bool CapNhatApDungKhuyenMai(ET_ApDungKhuyenMai et)
        {
            bool flag = false;
            try
            {
                var km = db.APDUNGKHUYENMAIs.Single(k => k.MAKM == et.MAKM && k.MAKH == et.MAKH);
                if (km != null)
                {
                    km.MATK = et.MATK;
                    km.NGAYAPDUNG = et.NGAYAPDUNG;
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
        // Xóa áp dụng khuyến mãi
        public bool XoaApDungKhuyenMai(ET_ApDungKhuyenMai et)
        {
            bool flag = false;
            try
            {
                var xoa = from adkm in db.APDUNGKHUYENMAIs
                          where adkm.MAKM == et.MAKM && adkm.MAKH == et.MAKH
                          select adkm;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.APDUNGKHUYENMAIs.DeleteOnSubmit(i);
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
