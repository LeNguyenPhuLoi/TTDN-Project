using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_PhongBan
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_PhongBan()
        {
            db = new QLNHDataContext();
        }

        //Lấy ds phòng ban
        public IQueryable LoadDSPB()
        {
            IQueryable PB = from pb in db.PHONGBANs
                            select pb;
            return PB;
        }

        //Thêm phòng ban
        public bool ThemPB(ET_PhongBan et)
        {
            bool ss = false;
            try
            {
                var amp = db.PHONGBANs.Any(pb => pb.MAPB == et.MaPB);
                if (!amp)
                {
                    PHONGBAN pb = new PHONGBAN
                    {
                        MAPB = et.MaPB,
                        TENPB = et.TenPB
                    };
                    db.PHONGBANs.InsertOnSubmit(pb);
                    db.SubmitChanges();
                    ss = true;
                }            
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Sửa phòng ban
        public bool SuaPB(ET_PhongBan et)
        {
            bool ss = false;
            try
            {
                var change = db.PHONGBANs.SingleOrDefault(pb => pb.MAPB == et.MaPB);
                if (change != null)
                {
                    change.MAPB = et.MaPB;
                    change.TENPB = et.TenPB;

                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Xóa phòng ban
        public bool XoaPB(ET_PhongBan et)
        {
            bool ss = false;
            try
            {
                var delete = db.PHONGBANs.SingleOrDefault(pb => pb.MAPB == et.MaPB);
                if (delete != null)
                {
                    db.PHONGBANs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }
    }
}
