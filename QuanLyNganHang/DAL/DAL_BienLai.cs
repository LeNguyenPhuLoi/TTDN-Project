using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_BienLai
    {
        //kết nối tới database = linq to sql
        QLNHDataContext db = new QLNHDataContext();

        //hàm lấy danh sách biên lai
        public IQueryable LayDSBienLai()
        {
            IQueryable BL = from bl in db.BIENLAIs
                            select bl;
            return BL;
        }

        //hàm thêm biên lai
        public bool ThemBienLai(ET_BienLai et)
        {
            bool flag = false;
            try
            {
                var exist = db.BIENLAIs.Any(x => x.MABL == et.MaBL);
                if (!exist) 
                {
                    BIENLAI bl = new BIENLAI()
                    {
                        MABL = et.MaBL,
                        MAGD = et.MaGD,
                        MAKH = et.MaKH,
                        MATK = et.MaTK,
                        MANV = et.MaNV,
                        SOTIEN = et.SoTien,
                        MALOAITIEN = et.MaLoaiTien,
                        LOAIBL = et.LoaiBL,
                        MOTA = et.Mota,
                        TRANGTHAI = et.TrangThai,
                    };
                    db.BIENLAIs.InsertOnSubmit(bl);
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

        //hàm sửa thông tin biên lai
        public bool SuaBienLai(ET_BienLai et)
        {
            bool flag = false;
            try
            {
                var update = db.BIENLAIs.SingleOrDefault(x => x.MABL == et.MaBL);
                if (update != null) 
                {
                    update.MAGD = et.MaGD;
                    update.MAKH = et.MaKH;
                    update.MATK = et.MaTK;
                    update.MANV = et.MaNV;
                    update.SOTIEN = et.SoTien;
                    update.MALOAITIEN = et.MaLoaiTien;
                    update.LOAIBL = et.LoaiBL;
                    update.MOTA = et.Mota;
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

        //hàm xóa biên lai
        public bool XoaBienLai(ET_BienLai et)
        {
            bool flag = false;
            try
            {
                var bl = db.BIENLAIs.SingleOrDefault(x => x.MABL == et.MaBL);
                if (bl != null)
                {               
                    db.BIENLAIs.DeleteOnSubmit(bl);
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
