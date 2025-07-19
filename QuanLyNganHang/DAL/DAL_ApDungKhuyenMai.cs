using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ApDungKhuyenMai
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ApDungKhuyenMai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lay danh sách khach hàng
        public IQueryable LoadDSKH()
        {
            IQueryable ds = from kh in db.KHACHHANGs
                            select new
                            {
                                kh.MAKH,
                                kh.TENKH,
                                kh.SDT,
                                kh.GIOITINH
                            };
            return ds;
        }

        // Lấy danh sách tài khoản
        public IQueryable LoadDSKM()
        {
            IQueryable ds = from tk in db.KHUYENMAIs
                            select new
                            {
                                tk.MAKM,
                                tk.TENKM,
                                tk.MOTA,
                                tk.NGAYBD,
                                tk.NGAYKT,
                                tk.DKAPDUNG
                            };
            return ds;
        }

        // Lấy danh sách áp dụng khuyến mãi
        public IQueryable LoadKhuyenMai()
        {
            IQueryable ds = from adkm in db.APDUNGKHUYENMAIs
                            select new
                            {
                                adkm.MAKM,
                                adkm.MAKH,
                                adkm.MATK,
                                adkm.NGAYAPDUNG
                            };
            return ds;
        }
        // Thêm Áp Dung khuyến mãi
        public bool ThemApDungKhuyenMai(ET_ApDungKhuyenMai et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            try
            {
                //ktra ap dung khuyến mãi có trống ko
                var checks = db.APDUNGKHUYENMAIs.FirstOrDefault(adkm => adkm.MAKM == et.MAKM && adkm.MAKH == et.MAKH);
                if (checks == null)
                {
                    error = "Vui lòng không để trống";
                    return false;
                }

                var exists = db.APDUNGKHUYENMAIs.Any(adkm => adkm.MAKM == et.MAKM && adkm.MAKH == et.MAKH);
                if (!exists)
                {
                    APDUNGKHUYENMAI km = new APDUNGKHUYENMAI
                    {
                        MAKM = et.MAKM,
                        MAKH = et.MAKH,
                        MATK = et.MATK,
                        NGAYAPDUNG = et.NGAYAPDUNG
                    };
                    db.APDUNGKHUYENMAIs.InsertOnSubmit(km);
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Khuyến mãi này đã được áp dụng cho khách hàng.";
                    return false;
                }
            }

            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                flag = false;
            }
            return flag;
        }
        // Sửa áp dụng khuyến mãi
        public bool CapNhatApDungKhuyenMai(ET_ApDungKhuyenMai et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            try
            {
                var km = db.APDUNGKHUYENMAIs.FirstOrDefault(k => k.MAKM == et.MAKM && k.MAKH == et.MAKH);
                if (km != null)
                {
                    km.MATK = et.MATK;
                    km.NGAYAPDUNG = et.NGAYAPDUNG;
                    db.SubmitChanges();
                    flag = true;
                }
                else if (km == null)
                {
                    error = "Vui lòng chọn dòng cần cập nhật";
                    return false;
                }
                else
                {
                    error = "Không tìm thấy áp dụng khuyến mãi với mã khuyến mãi và mã khách hàng đã cho.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                flag = false;
            }
            return flag;
        }
        // Xóa áp dụng khuyến mãi
        public bool XoaApDungKhuyenMai(ET_ApDungKhuyenMai et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            try
            {
                var xoa = db.APDUNGKHUYENMAIs.FirstOrDefault(c => c.MAKH == et.MAKH && c.MAKM == et.MAKM);

                if (xoa != null)
                {
                    db.APDUNGKHUYENMAIs.DeleteOnSubmit(xoa);
                    db.SubmitChanges();
                    flag = true;

                }
                else if (xoa == null)
                {
                    error = "Vui lòng chọn dòng cần xóa";
                    return false;
                }
                else
                {
                    error = "Không tìm thấy áp dụng khuyến mãi với mã khuyến mãi và mã khách hàng đã cho.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                flag = false;
            }
            return flag;
        }

        //Tìm kiếm áp dụng khuyến mãi
        DAL_ChuyenKhoan dl = new DAL_ChuyenKhoan();

        public IQueryable TimKiemADKM(string keyword)
        {
            DateTime parsedDate;
            bool isDate = dl.IsValidSqlDate(keyword, out parsedDate);

            var ds = from km in db.APDUNGKHUYENMAIs
                     where km.MAKM.Contains(keyword)
                        || km.MAKH.Contains(keyword)
                        || km.MATK.Contains(keyword)
                        || (isDate && km.NGAYAPDUNG == parsedDate.Date)
                     select new
                     {
                         km.MAKM,
                         km.MAKH,
                         km.MATK,
                         km.NGAYAPDUNG
                     };
            return ds;
        }
    }
}
