﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ET;

namespace DAL
{
    public class DAL_TaiKhoanRP
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_TaiKhoanRP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách tài khoản cho report
        public List<ET_TaiKhoanRP> LoadDSTaiKhoan()
        {
            var query = from tk in db.TAIKHOANs
                        join kh in db.KHACHHANGs on tk.MAKH equals kh.MAKH
                        join ltk in db.LOAITAIKHOANs on tk.MALOAITK equals ltk.MALOAITK
                        join lt in db.LOAITIENs on tk.MALOAITIEN equals lt.MALOAITIEN
                        select new ET_TaiKhoanRP
                        {
                            MaTK = tk.MATK,
                            TenKH = kh.TENKH,
                            SoTaiKhoan = tk.SOTAIKHOAN,
                            ChiTiet = ltk.CHITIET,
                            SoDu = Convert.ToDecimal(tk.SODU),
                            TenLoaiTien = lt.TENLOAITIEN,
                            NgayMoTK = Convert.ToDateTime(tk.NGAYMOTK),
                            TrangThai = tk.TRANGTHAI,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách tài khoản cho report theo mã
        public List<ET_TaiKhoanRP> LoadDSTaiKhoanTheoMa(string ma)
        {
            var query = from tk in db.TAIKHOANs
                        join kh in db.KHACHHANGs on tk.MAKH equals kh.MAKH
                        join ltk in db.LOAITAIKHOANs on tk.MALOAITK equals ltk.MALOAITK
                        join lt in db.LOAITIENs on tk.MALOAITIEN equals lt.MALOAITIEN
                        where tk.MATK.Contains(ma)
                        select new ET_TaiKhoanRP
                        {
                            MaTK = tk.MATK,
                            TenKH = kh.TENKH,
                            SoTaiKhoan = tk.SOTAIKHOAN,
                            ChiTiet = ltk.CHITIET,
                            SoDu = Convert.ToDecimal(tk.SODU),
                            TenLoaiTien = lt.TENLOAITIEN,
                            NgayMoTK = Convert.ToDateTime(tk.NGAYMOTK),
                            TrangThai = tk.TRANGTHAI,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách tài khoản cho report theo tên khách hàng
        public List<ET_TaiKhoanRP> LoadDSTaiKhoanTheoTenKH(string ten)
        {
            var query = from tk in db.TAIKHOANs
                        join kh in db.KHACHHANGs on tk.MAKH equals kh.MAKH
                        join ltk in db.LOAITAIKHOANs on tk.MALOAITK equals ltk.MALOAITK
                        join lt in db.LOAITIENs on tk.MALOAITIEN equals lt.MALOAITIEN
                        where kh.TENKH.Contains(ten)
                        select new ET_TaiKhoanRP
                        {
                            MaTK = tk.MATK,
                            TenKH = kh.TENKH,
                            SoTaiKhoan = tk.SOTAIKHOAN,
                            ChiTiet = ltk.CHITIET,
                            SoDu = Convert.ToDecimal(tk.SODU),
                            TenLoaiTien = lt.TENLOAITIEN,
                            NgayMoTK = Convert.ToDateTime(tk.NGAYMOTK),
                            TrangThai = tk.TRANGTHAI,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách tài khoản cho report theo số tài khoản
        public List<ET_TaiKhoanRP> LoadDSTaiKhoanTheoSoTK(string sotk)
        {
            var query = from tk in db.TAIKHOANs
                        join kh in db.KHACHHANGs on tk.MAKH equals kh.MAKH
                        join ltk in db.LOAITAIKHOANs on tk.MALOAITK equals ltk.MALOAITK
                        join lt in db.LOAITIENs on tk.MALOAITIEN equals lt.MALOAITIEN
                        where tk.SOTAIKHOAN.Contains(sotk)
                        select new ET_TaiKhoanRP
                        {
                            MaTK = tk.MATK,
                            TenKH = kh.TENKH,
                            SoTaiKhoan = tk.SOTAIKHOAN,
                            ChiTiet = ltk.CHITIET,
                            SoDu = Convert.ToDecimal(tk.SODU),
                            TenLoaiTien = lt.TENLOAITIEN,
                            NgayMoTK = Convert.ToDateTime(tk.NGAYMOTK),
                            TrangThai = tk.TRANGTHAI,
                        };

            return query.ToList();
        }
    }

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

        //hàm tìm tài khoản theo mã tài khoản
        public IQueryable TimTKTheoMaTK(string ma)
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            where tk.MATK.Contains(ma)
                            select tk;
            return TK;
        }

        //hàm tìm tài khoản theo tên khách hàng
        public IQueryable TimTKTheoTenKH(string tenkh)
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            where tk.MAKH.Contains(LayMaKHTheoTen(tenkh))
                            select tk;
            return TK;
        }

        //hàm tìm tài khoản theo số tài khoản
        public IQueryable TimTKTheoSTK(string stk)
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            where tk.SOTAIKHOAN.Contains(stk)
                            select tk;
            return TK;
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
                    update.MAKH = et.MaKH;
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
