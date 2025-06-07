using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        
        QLNHDataContext db = new QLNHDataContext();

        public IQueryable LoadKM()
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            select km;
            return KM;
        }

        public IQueryable TimKMTheoMa(string ma)
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            where km.MAKM.Contains(ma)
                            select km;
            return KM;
        }

        public IQueryable TimKMTheoTen(string ten)
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            where km.TENKM.Contains(ten)
                            select km;
            return KM;
        }

        public bool ThemKM(ET_KhuyenMai et)
        {
            bool clone = false;
            try
            {
                var space = db.KHUYENMAIs.Any(x => x.MAKM == et.MAKM);
                if (!space)
                {
                    KHUYENMAI km = new KHUYENMAI()
                    {
                        MAKM = et.MAKM,
                        TENKM = et.TENKM,
                        MOTA = et.MOTA,
                        NGAYBD = et.NGAYBD,
                        NGAYKT = et.NGAYKT,
                        DKAPDUNG = et.DKAPDUNG
                    };

                    db.KHUYENMAIs.InsertOnSubmit(km);
                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                clone = false;
                Console.WriteLine("Lỗi khi thêm khuyến mãi: " + ex.Message);
            }
            return clone;
        }

        public bool SuaKM(ET_KhuyenMai et)
        {
            bool clone = false;
            try
            {
                var capnhat = db.KHUYENMAIs.Single(km => km.MAKM == et.MAKM);
                if (capnhat != null)
                {
                    capnhat.TENKM = et.TENKM;
                    capnhat.MOTA = et.MOTA;
                    capnhat.NGAYBD = et.NGAYBD;
                    capnhat.NGAYKT = et.NGAYKT;
                    capnhat.DKAPDUNG = et.DKAPDUNG;

                    db.SubmitChanges();
                    clone = true;
                }
            }
            catch (Exception ex)
            {
                clone = false;
                Console.WriteLine("Lỗi khi sửa khuyến mãi: " + ex.Message);
            }
            return clone;
        }

        public bool XoaKM(ET_KhuyenMai et)
        {
            bool clone = false;
            try
            {
                var xoa = from km in db.KHUYENMAIs
                          where km.MAKM == et.MAKM
                          select km;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.KHUYENMAIs.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    clone = true;
                }

            }
            catch (Exception ex)
            {
                clone = false;
                Console.WriteLine("Lỗi khi xóa khuyến mãi: " + ex.Message);
            }
            return clone;
        }
    }
}
