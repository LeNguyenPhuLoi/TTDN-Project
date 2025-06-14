using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ChiNhanh
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ChiNhanh()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lấy ds chi nhánh
        public IQueryable LoadDSCN()
        {
            IQueryable CN = from cn in db.CHINHANHs
                            select cn;
            return CN;
        }

        //Thêm chi nhánh
        public bool ThemCN(ET_ChiNhanh et)
        {
            bool ss = false;
            try
            {
                var amp = db.CHINHANHs.Any(cn => cn.MACN == et.MaCN);
                if (!amp)
                {
                    CHINHANH cn = new CHINHANH
                    {
                        MACN = et.MaCN,
                        TENCN = et.TenCN,
                        DIACHICN = et.DiaChiCN,
                        SDTCN = et.SdtCN
                    };
                    db.CHINHANHs.InsertOnSubmit(cn);
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

        //Sửa chi nhánh
        public bool SuaCN(ET_ChiNhanh et)
        {
            bool ss = false;
            try
            {
                var change = db.CHINHANHs.SingleOrDefault(cn => cn.MACN == et.MaCN);
                if (change != null)
                {
                    change.MACN = et.MaCN;
                    change.TENCN = et.TenCN;
                    change.DIACHICN = et.DiaChiCN;
                    change.SDTCN = et.SdtCN;

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

        //Xóa chi nhánh
        public bool XoaCN(ET_ChiNhanh et)
        {
            bool ss = false;
            try
            {
                var delete = db.CHINHANHs.SingleOrDefault(cn => cn.MACN == et.MaCN);
                if (delete != null)
                {
                    db.CHINHANHs.DeleteOnSubmit(delete);
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
