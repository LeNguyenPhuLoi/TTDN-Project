using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_NoiQuy
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_NoiQuy()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lấy ds nhân viên
        public IQueryable LoadDSNQ()
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            select nq;
            return NQ;
        }

        public IQueryable LoadTieuDe()
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            select nq.TIEUDE;
            return NQ;
        }

        public IQueryable TimNQTheoMa(string ma)
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            where nq.MANQ.Contains(ma)
                            select nq;
            return NQ;
        }

        public IQueryable TimNQTheoTieuDe(string tieude)
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            where nq.TIEUDE.Contains(tieude)
                            select nq;
            return NQ;
        }

        //Thêm nội quy
        public bool ThemNQ(ET_NoiQuy et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var amp = db.NOIQUYs.Any(nq => nq.MANQ == et.MaNQ);
                if (!amp)
                {
                    NOIQUY nq = new NOIQUY
                    {
                        MANQ = et.MaNQ,
                        TIEUDE = et.TieuDe,
                        MOTA = et.MoTa,
                        NGAYBH = et.NgayBH,
                        LOAIAPDUNG = et.LoaiApDung
                    };
                    db.NOIQUYs.InsertOnSubmit(nq);
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

        //Sửa nội quy
        public bool SuaNQ(ET_NoiQuy et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.NOIQUYs.SingleOrDefault(nq => nq.MANQ == et.MaNQ);
                if (change != null)
                {
                    change.MANQ = et.MaNQ;
                    change.TIEUDE = et.TieuDe; 
                    change.MOTA = et.MoTa;
                    change.NGAYBH = et.NgayBH;
                    change.LOAIAPDUNG = et.LoaiApDung;

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

        //Xóa nội quy
        public bool XoaNQ(ET_NoiQuy et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var delete = db.NOIQUYs.SingleOrDefault(nq => nq.MANQ == et.MaNQ);
                if (delete != null)
                {
                    db.NOIQUYs.DeleteOnSubmit(delete);
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
