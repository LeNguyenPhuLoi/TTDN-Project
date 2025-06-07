using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_LaiSuat
    {
        QLNHDataContext db = new QLNHDataContext();

        // Lấy danh sách lãi suất
        public IQueryable LoadLaiSuat()
        {
            IQueryable ds = from ls in db.LAISUATs
                            select ls;
            return ds;
        }

        // Thêm lãi suất
        public bool ThemLaiSuat(ET_LaiSuat et)
        {
            bool flag = false;
            try
            {
                var exists = db.LAISUATs.Any(ls => ls.MALAISUAT == et.MALAISUAT);
                if (!exists)
                {
                    LAISUAT ls = new LAISUAT
                    {
                        MALAISUAT = et.MALAISUAT,
                        TENLOAIVAY = et.TENLAISUAT,
                        LAISUAT1 = et.LAISUAT
                    };
                    db.LAISUATs.InsertOnSubmit(ls);
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

        // Sửa lãi suất
        public bool CapNhatLaiSuat(ET_LaiSuat et)
        {
            bool flag = false;
            try
            {
                var ls = db.LAISUATs.Single(l => l.MALAISUAT == et.MALAISUAT);
                if (ls != null)
                {
                    ls.TENLOAIVAY = et.TENLAISUAT;
                    ls.LAISUAT1 = et.LAISUAT;
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

        // Xóa lãi suất
        public bool XoaLaiSuat(ET_LaiSuat et)
        {
            bool flag = false;
            try
            {
                var xoa = from ls in db.LAISUATs
                          where ls.MALAISUAT == et.MALAISUAT
                          select ls;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.LAISUATs.DeleteOnSubmit(i);
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
