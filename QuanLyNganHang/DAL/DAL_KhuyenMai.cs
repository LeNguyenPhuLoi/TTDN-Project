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

        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_KhuyenMai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public IQueryable LoadKM()
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            select new
                            {
                                km.MAKM,
                                km.TENKM,
                                km.MOTA,
                                km.NGAYBD,
                                km.NGAYKT,
                                km.DKAPDUNG
                            };
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

        public bool ThemKM(ET_KhuyenMai et, out string error)
        {
            error = string.Empty;
            bool clone = false;
            try
            {
                //ktra xem ma khuyến mãi đã tồn tại chưa
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
                else
                {
                    error = "Mã khuyến mãi đã tồn tại.";
                }
            }
            catch (Exception ex)
            {
                clone = false;
                error = "Lỗi khi thêm khuyến mãi: \n\n" + ex.Message;
            }
            return clone;
        }

        public bool SuaKM(ET_KhuyenMai et, out string error)
        {
            error = string.Empty;
            bool clone = false;
            try
            {

                //kiểm tra xem mã khuyến mãi có tồn tại không
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
                } else
                {
                    error = "Mã khuyến mãi không tồn tại cập nhật thất bại.";
                }
            }
            catch (Exception ex)
            {
                clone = false;
                error = "Lỗi khi sửa khuyến mãi: \n\n" + ex.Message;
            }
            return clone;
        }

        public bool XoaKM(ET_KhuyenMai et, out string error)
        {
            error = string.Empty;
            bool clone = false;
            try
            {
                //kiểm tra xem mã khuyến mãi có tồn tại không
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
                else
                {
                    error = "Mã khuyến mãi không tồn tại.";
                }

            }
            catch (Exception ex)
            {
                clone = false;
                error = "Lỗi khi xóa khuyến mãi: " + ex.Message;
            }
            return clone;
        }

        DAL_ChuyenKhoan dl = new DAL_ChuyenKhoan();

        //Tìm Kiếm Khuyến Mãi
        public IQueryable TimKiemKhuyenMai(string keyword)
        {
            DateTime parsedDate;
            bool isDate = dl.IsValidSqlDate(keyword, out parsedDate);

            var ds = from km in db.KHUYENMAIs
                     where km.MAKM.Contains(keyword)
                        || km.TENKM.Contains(keyword)
                        || km.MOTA.Contains(keyword)
                        || (isDate && km.NGAYBD == parsedDate.Date)
                        || (isDate && km.NGAYKT == parsedDate.Date)
                        || km.DKAPDUNG.Contains(keyword)
                     select new
                     {
                         km.MAKM,
                         km.TENKM,
                         km.MOTA,
                         km.NGAYBD,
                         km.NGAYKT,
                         km.DKAPDUNG
                     };
            return ds;
        }
    }
}
