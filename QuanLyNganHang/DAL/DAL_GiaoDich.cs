using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_GiaoDich
    {
        //kết nối với database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_GiaoDich()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách giao dịch
        public IQueryable LayDSGiaoDich()
        {
            IQueryable GD = from gd in db.GIAODICHes
                            select gd;
            return GD;
        }

        //hàm thêm giao dịch
        public bool ThemGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;
            try
            {
                var exist = db.GIAODICHes.Any(x => x.MAGD == et.LoaiGD);
                if (!exist)
                {
                    GIAODICH gd = new GIAODICH()
                    {
                        MAGD = et.MaGD,
                        MATK = et.MaTK,
                        LOAIGD = et.LoaiGD,
                        SOTIEN = et.SoTien,
                        THOIGIANGD = et.ThoiGianGD,
                        MOTA = et.MoTa,
                        TRANGTHAI = et.TrangThai
                    };
                    db.GIAODICHes.InsertOnSubmit(gd);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: "+ex.ToString());
            }
            return flag;
        }

        //hàm sửa thông tin giao dịch
        public bool SuaGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;
            try
            {
                var update = db.GIAODICHes.SingleOrDefault(x => x.MAGD == et.MaGD);
                if(update != null)
                {
                    update.MATK = et.MaTK;
                    update.LOAIGD = et.LoaiGD;
                    update.SOTIEN = et.SoTien;
                    update.THOIGIANGD = et.ThoiGianGD;
                    update.MOTA = et.MoTa;
                    update.TRANGTHAI = et.TrangThai;

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

        //hàm xóa giao dịch
        public bool XoaGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;
            try
            {
                var gd = db.GIAODICHes.SingleOrDefault(x => x.MAGD == et.MaGD);
                if (gd != null)
                {
                    db.GIAODICHes.DeleteOnSubmit(gd);
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
    }
}
