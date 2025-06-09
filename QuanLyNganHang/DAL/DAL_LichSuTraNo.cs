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
        QLNHDataContext db = new QLNHDataContext();
        // Lấy danh sách lịch sử trả nợ
        public IQueryable LoadLichSuTraNo()
        {
            IQueryable ds = from ls in db.LICHSUTRANOs
                            select ls;
            return ds;
        }
        // Thêm lịch sử trả nợ
        public bool ThemLichSuTraNo(ET_LichSuTraNo et)
        {
            bool flag = false;
            try
            {
                var exists = db.LICHSUTRANOs.Any(ls => ls.MALICHSU == et.MALICHSU);
                if (!exists)
                {
                    LICHSUTRANO ls = new LICHSUTRANO
                    {
                        MALICHSU = et.MALICHSU,
                        MAVAY = et.MAVAY,
                        SOTIENTRA = et.SOTIENTRA,
                        NGAYTRA = et.NGAYTRA
                    };
                    db.LICHSUTRANOs.InsertOnSubmit(ls);
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
        // Sửa lịch sử trả nợ
        public bool CapNhatLichSuTraNo(ET_LichSuTraNo et)
        {
            bool flag = false;
            try
            {
                var ls = db.LICHSUTRANOs.Single(l => l.MALICHSU == et.MALICHSU);
                if (ls != null)
                {
                    ls.MAVAY = et.MAVAY;
                    ls.SOTIENTRA = et.SOTIENTRA;
                    ls.NGAYTRA = et.NGAYTRA;
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
        // Xóa lịch sử trả nợ
        public bool XoaLichSuTraNo(ET_LichSuTraNo et)
        {
            bool flag = false;
            try
            {
                var xoa = from ls in db.LICHSUTRANOs
                          where ls.MALICHSU == et.MALICHSU
                          select ls;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.LICHSUTRANOs.DeleteOnSubmit(i);
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
