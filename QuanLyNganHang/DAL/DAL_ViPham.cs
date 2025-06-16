using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ViPham
    {
        ////Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ViPham()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lấy ds nhân viên
        public IQueryable LoadDSVP()
        {
            IQueryable VP = from vp in db.VIPHAMs
                            select new {vp.MAVP, vp.MANQ, vp.MANV, vp.MAKH, vp.NGAYVP, vp.MOTAVP, vp.HINHTHUCXL, vp.TRANGTHAIXL };
            return VP;
        }

        public IQueryable LoadNQ()
        {
            IQueryable NQ = from nq in db.NOIQUYs
                            select nq.TIEUDE;
            return NQ;
        }

        public IQueryable LoadNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select nv.TENNV;
            return NV;
        }

        public IQueryable LoadKH()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select kh.TENKH;
            return KH;
        }

        public string LayTieuDeNQTheoMa(string ma)
        {
            string ten = (from nq in db.NOIQUYs
                            where nq.MANQ == ma
                            select nq.TIEUDE).FirstOrDefault();
            return ten;
        }

        public string LayTenNVTheoMa(string ma)
        {
            string ten = (from nv in db.NHANVIENs
                          where nv.MANV == ma
                          select nv.TENNV).FirstOrDefault();
            return ten;
        }

        public string LayTenKHTheoMa(string ma)
        {
            string ten = (from kh in db.KHACHHANGs
                          where kh.MAKH == ma
                          select kh.TENKH).FirstOrDefault();
            return ten;
        }

        public string LayMaNQTheoTieuDe(string ten)
        {
            string ma = (from nq in db.NOIQUYs
                         where nq.TIEUDE == ten
                         select nq.MANQ).FirstOrDefault();
            return ma;
        }

        public string LayMaNVTheoTen(string ten)
        {
            string ma = (from nv in db.NHANVIENs
                         where nv.TENNV == ten
                         select nv.MANV).FirstOrDefault();
            return ma;
        }

        public string LayMaKHTheoTen(string ten)
        {
            string ma = (from kh in db.KHACHHANGs
                         where kh.TENKH == ten
                         select kh.MAKH).FirstOrDefault();
            return ma;
        }

        //Thêm vi phạm
        public bool ThemVP(ET_ViPham et)
        {
            bool ss = false;
            try
            {
                var amp = db.VIPHAMs.Any(vp => vp.MAVP == et.MaVP);
                if (!amp)
                {
                    VIPHAM vp = new VIPHAM
                    {
                        MAVP = et.MaVP,
                        MANQ = et.MaNQ,
                        MANV = et.MaNV,
                        MAKH = et.MaKH,
                        NGAYVP = et.NgayVP,
                        MOTAVP = et.MoTaVP,
                        HINHTHUCXL = et.HinhThucXL,
                        TRANGTHAIXL = et.TrangThaiXL
                    };
                    db.VIPHAMs.InsertOnSubmit(vp);
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

        //Sửa vi phạm
        public bool SuaVP(ET_ViPham et)
        {
            bool ss = false;
            try
            {
                var change = db.VIPHAMs.SingleOrDefault(vp => vp.MAVP == et.MaVP);
                if (change != null)
                {
                    change.MAVP = et.MaVP;
                    change.MANQ = et.MaNQ;
                    change.MANV = et.MaNV;
                    change.MAKH = et.MaKH;
                    change.NGAYVP = et.NgayVP;
                    change.MOTAVP = et.MoTaVP;
                    change.HINHTHUCXL = et.HinhThucXL;
                    change.TRANGTHAIXL = et.TrangThaiXL;

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

        //Xóa vi phạm
        public bool XoaVP(ET_ViPham et)
        {
            bool ss = false;
            try
            {
                var delete = db.VIPHAMs.SingleOrDefault(vp => vp.MAVP == et.MaVP);
                if (delete != null)
                {
                    db.VIPHAMs.DeleteOnSubmit(delete);
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
