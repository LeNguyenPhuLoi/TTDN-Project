using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_KhoanVay
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;
        
        public DAL_KhoanVay()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //lay ten khach hang
        public IQueryable LoadTenKhachHang()
        {
            IQueryable ds = from kh in db.KHACHHANGs
                               select kh.TENKH;
            return ds;
        }

        // Lấy mã khách hàng theo ten
        public string GetMaKhachHang(string tenKhachHang)
        {
            var maKhachHang = (from kh in db.KHACHHANGs
                               where kh.TENKH == tenKhachHang
                               select kh.MAKH).FirstOrDefault();
            return maKhachHang;
        }

        //lay ten theo ma khach hang
        public string GetTenKhachHang(string maKhachHang)
        {
            var tenKhachHang = (from kh in db.KHACHHANGs
                                where kh.MAKH == maKhachHang
                                select kh.TENKH).FirstOrDefault();
            return tenKhachHang;
        }

        // Lấy danh sách khoản vay
        public IQueryable LoadKhoanVay()
        {
            IQueryable ds = from kv in db.KHOANVAYs
                            select new 
                            { 
                                kv.MAVAY,
                                kv.SOTIENVAY,
                                kv.TONGTIEN,
                                kv.TIENTHANG,
                                kv.NGAYVAY,
                                kv.THOIHAN,
                                kv.SOTHANG,
                                kv.TRANGTHAI,
                                kv.MAKH,
                                kv.MALAISUAT
                            };
            return ds;
        }

        // Thêm khoản vay
        public bool ThemKhoanVay(ET_KhoanVay et,out string error)
        {
            error = string.Empty;
            bool flag = false;
            try
            {
                var exists = db.KHOANVAYs.Any(kv => kv.MAVAY == et.MAVAY);
                if (!exists)
                {
                    KHOANVAY kv = new KHOANVAY
                    {
                        MAVAY = et.MAVAY,
                        SOTIENVAY = et.SOTIENVAY,
                        TONGTIEN = et.TONGTIEN,
                        TIENTHANG = et.TIENTHANG,
                        NGAYVAY = et.NGAYVAY,
                        THOIHAN = et.THOIHAN,
                        SOTHANG = et.SOTHANG,
                        TRANGTHAI = et.TRANGTHAI,
                        MAKH = et.MAKH,
                        MALAISUAT = et.MALAISUAT
                    };
                    db.KHOANVAYs.InsertOnSubmit(kv);
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã khoản vay đã tồn tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                error = "Lỗi: " + ex.ToString();
            }
            return flag;
        }

        // Sửa khoản vay
        public bool CapNhatKhoanVay(ET_KhoanVay et,out string error)
        {
            error = string.Empty;
            bool flag = false;
            try
            {
                var kv = db.KHOANVAYs.Single(k => k.MAVAY == et.MAVAY);
                if (kv != null)
                {
                    kv.SOTIENVAY = et.SOTIENVAY;
                    kv.TONGTIEN = et.TONGTIEN;
                    kv.TIENTHANG = et.TIENTHANG;
                    kv.NGAYVAY = et.NGAYVAY;
                    kv.THOIHAN = et.THOIHAN;
                    kv.SOTHANG = et.SOTHANG;
                    kv.TRANGTHAI = et.TRANGTHAI;
                    kv.MAKH = et.MAKH;
                    kv.MALAISUAT = et.MALAISUAT;
                    db.SubmitChanges();
                    flag = true;
                } 
                else
                {
                    error = "Mã khoản vay không tồn tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                error = "Lỗi: " + ex.ToString();
            }
            return flag;
        }

        // Xóa khoản vay
        public bool XoaKhoanVay(ET_KhoanVay et,out string error)
        {
            error = string.Empty;
            bool flag = false;
            try
            {
                var xoa = from kv in db.KHOANVAYs
                          where kv.MAVAY == et.MAVAY
                          select kv;
                if (xoa != null)
                {
                    foreach (var i in xoa)
                    {
                        db.KHOANVAYs.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    flag = true;
                }
                else
                {
                    error = "Mã khoản vay không tồn tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                error = "Lỗi: " + ex.ToString();
            }
            return flag;
        }

        DAL_ChuyenKhoan dl = new DAL_ChuyenKhoan();

        //Tìm kiếm khoảm vay
        public IQueryable TimKiemKhoanVay(string keyword)
        {
            DateTime parsedDate;
            bool isDate = dl.IsValidSqlDate(keyword, out parsedDate);

            var ds = from kv in db.KHOANVAYs
                     where kv.MAVAY.Contains(keyword)
                        || kv.SOTIENVAY.ToString().Contains(keyword)
                        || kv.TONGTIEN.ToString().Contains(keyword)
                        || kv.TIENTHANG.ToString().Contains(keyword)
                        || kv.NGAYVAY.ToString().Contains(keyword)
                        || kv.THOIHAN.ToString().Contains(keyword)
                        || kv.SOTHANG.ToString().Contains(keyword)
                        || kv.TRANGTHAI.Contains(keyword)
                        || kv.MAKH.Contains(keyword)
                        || kv.MALAISUAT.Contains(keyword)
                        || (isDate && kv.NGAYVAY == parsedDate.Date)
                        || (isDate && kv.THOIHAN == parsedDate.Date)
                     select new
                     {
                         kv.MAVAY,
                         kv.SOTIENVAY,
                         kv.TONGTIEN,
                         kv.TIENTHANG,
                         kv.NGAYVAY,
                         kv.THOIHAN,
                         kv.SOTHANG,
                         kv.TRANGTHAI,
                         kv.MAKH,
                         kv.MALAISUAT
                     };
            return ds;
        }
    }
}
