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
                            select vp;
            return VP;
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
