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
                                kv.SOTIENLAI,
                                kv.NGAYVAY,
                                kv.THOIHAN,
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
                        SOTIENLAI = et.SOTIENLAI,
                        NGAYVAY = et.NGAYVAY,
                        THOIHAN = et.THOIHAN,
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
                    kv.SOTIENLAI = et.SOTIENLAI;
                    kv.NGAYVAY = et.NGAYVAY;
                    kv.THOIHAN = et.THOIHAN;
                    kv.TRANGTHAI = et.TRANGTHAI;
                    kv.MAKH = et.MAKH;
                    kv.MALAISUAT = et.MALAISUAT;
                    db.SubmitChanges();
                    flag = true;
                } 
                else
                {
                    error = "Mã khoản vay không tồn tại!";
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
                }
            }
            catch (Exception ex)
            {
                flag = false;
                error = "Lỗi: " + ex.ToString();
            }
            return flag;
        }

        public decimal TinhTienLai(decimal soTienVay, string maLaiSuat, string ngayVayStr, string ngayTraStr)
        {
            // Chuyển đổi ngày
            DateTime ngayVay = DateTime.ParseExact(ngayVayStr, "dd/MM/yyyy", null);
            DateTime ngayTra = DateTime.ParseExact(ngayTraStr, "dd/MM/yyyy", null);

            if (ngayTra < ngayVay)
                throw new Exception("Ngày trả không được nhỏ hơn ngày vay.");

            int soNgay = (ngayTra - ngayVay).Days;
            if (soNgay == 0) soNgay = 1;

            // Lấy lãi suất
            var laiSuat = (from ls in db.LAISUATs
                           where ls.MALAISUAT == maLaiSuat
                           select ls.LAISUAT1).FirstOrDefault();

            if (laiSuat == null)
                throw new Exception("Mã lãi suất không tồn tại.");

            decimal laiSuatThuc = (decimal)laiSuat / 100;

            // Giả sử lãi suất là theo năm:
            decimal tienLai = Math.Round(soTienVay * laiSuatThuc * soNgay / 365, 0); // Hoặc không làm tròn

            return tienLai;
        }

    }
}
