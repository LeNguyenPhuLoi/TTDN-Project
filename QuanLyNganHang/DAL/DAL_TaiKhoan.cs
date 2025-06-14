using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ET;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_TaiKhoan()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Hàm lấy danh sách tài khoản
        public IQueryable LayDSTaiKhoan()
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            select tk;
            return TK;
        }

        //Hàm lấy danh sách loại tài khoản
        public IQueryable LayDSLoaiTaiKhoan()
        {
            IQueryable LTK = from ltk in db.LOAITAIKHOANs
                            select ltk.CHITIET;
            return LTK;
        }

        //Hàm lấy danh sách tên loại tiền
        public IQueryable LayDSTenLoaiTien()
        {
            IQueryable LT = from lt in db.LOAITIENs
                             select lt.TENLOAITIEN;
            return LT;
        }

        //hàm lấy danh sách tên khách hàng
        public IQueryable LayDSTenKH()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select kh.TENKH;
            return KH;
        }

        //hàm lấy mã khách hàng theo tên
        public string LayMaKHTheoTen(string ten)
        {
            string ma = (from kh in db.KHACHHANGs
                            where kh.TENKH == ten
                            select kh.MAKH).FirstOrDefault();
            return ma;
        }

        //hàm lấy tên khách hàng theo mã
        public string LayTenKHTheoMa(string ma)
        {
            string ten = (from kh in db.KHACHHANGs
                         where kh.MAKH == ma
                         select kh.TENKH).FirstOrDefault();
            return ten;
        }

        //hàm lấy mã loại tài khoản theo chi tiết
        public string LayMaLTKTheoChiTiet(string chitiet)
        {
            string ma = (from ltk in db.LOAITAIKHOANs
                         where ltk.CHITIET == chitiet
                         select ltk.MALOAITK).FirstOrDefault();
            return ma;
        }

        //hàm lấy chi tiết theo mã loại tài khoản
        public string LayChiTietTheoMaLTK(string ma)
        {
            string chitiet = (from ltk in db.LOAITAIKHOANs
                         where ltk.MALOAITK == ma
                         select ltk.CHITIET).FirstOrDefault();
            return chitiet;
        }

        //hàm lấy mã loại tiền theo tên
        public string LayMaLTTheoTen(string ten)
        {
            string ma = (from lt in db.LOAITIENs
                         where lt.TENLOAITIEN == ten
                         select lt.MALOAITIEN).FirstOrDefault();
            return ma;
        }

        //hàm lấy tên theo mã loại tiền
        public string LayTenTheoMaLT(string ma)
        {
            string ten = (from lt in db.LOAITIENs
                         where lt.MALOAITIEN == ma
                         select lt.TENLOAITIEN).FirstOrDefault();
            return ten;
        }

        //hàm thêm tài khoản
        public bool ThemTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;
            try
            {
                var exist = db.TAIKHOANs.Any(x => x.MATK == et.MaTK);
                if (!exist)
                {
                    TAIKHOAN tk = new TAIKHOAN()
                    {
                        MATK = et.MaTK,
                        MAKH = et.MaKH,
                        SOTAIKHOAN = et.SoTaiKhoan,
                        MALOAITK = et.MaLoaiTK,
                        SODU = et.SoDu,
                        MALOAITIEN = et.MaLoaiTien,
                        NGAYMOTK = et.NgayMoTK,
                        TRANGTHAI = et.TrangThai
                    };
                    db.TAIKHOANs.InsertOnSubmit(tk);
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

        //hàm sửa thông tin tài khoản
        public bool SuaTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;
            try
            {
                var update = db.TAIKHOANs.SingleOrDefault(x => x.MATK == et.MaTK);
                if (update != null)
                {
                    var khachHang = db.KHACHHANGs.SingleOrDefault(kh => kh.MAKH == et.MaKH);
                    if (khachHang != null)
                    {
                        update.KHACHHANG = khachHang; // Gán thông qua liên kết thay vì update.MAKH
                    }

                    update.SOTAIKHOAN = et.SoTaiKhoan;
                    update.MALOAITK = et.MaLoaiTK;
                    update.SODU = et.SoDu;
                    update.MALOAITIEN = et.MaLoaiTien;
                    update.NGAYMOTK = et.NgayMoTK;
                    update.TRANGTHAI = et.TrangThai;

                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            return flag;
        }

        //hàm xóa tài khoản
        public bool XoaTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;
            try
            {
                var tk = db.TAIKHOANs.SingleOrDefault(x => x.MATK == et.MaTK);
                if (tk != null)
                {
                    db.TAIKHOANs.DeleteOnSubmit(tk);
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
