using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ET;

namespace DAL
{
    public class DAL_BienLai
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_BienLai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách biên lai
        public IQueryable LayDSBienLai()
        {
            IQueryable BL = from bl in db.BIENLAIs
                            select bl;
            return BL;
        }


        //hàm tìm biên lai theo mã biên lai
        public IQueryable TimBLTheoMaBl(string ma)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MABL.Contains(ma)
                            select bl;
            return BL;
        }

        //hàm tìm biên lai theo mã giao dịch
        public IQueryable TimBLTheoMaGD(string ma)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MAGD.Contains(ma)
                            select bl;
            return BL;
        }

        //hàm tìm biên lai theo tên khách hàng
        public IQueryable TimBLTheoTenKH(string ten)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MAKH.Contains(LayMaKHTheoTen(ten))
                            select bl;
            return BL;
        }

        //hàm tìm biên lai theo số tài khoản
        public IQueryable TimBLTheoSTK(string stk)
        {
            IQueryable BL = from bl in db.BIENLAIs
                            where bl.MATK.Contains(LayMaTKTheoSo(stk))
                            select bl;
            return BL;
        }

        //hàm lấy số tài khoản
        public IQueryable LaySTK()
        {
            IQueryable STK = from tk in db.TAIKHOANs
                             select tk.SOTAIKHOAN;
            return STK;
        }

        //hàm lấy tên khách hàng
        public IQueryable LayTenKH()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select kh.TENKH;
            return KH;
        }

        //hàm lấy mã giao dịch
        public IQueryable LayMaGD()
        {
            IQueryable GD = from gd in db.GIAODICHes
                            select gd.MAGD;
            return GD;
        }

        //hàm lấy tên khách hàng theo mã biên lai
        public IQueryable LayTenKHTheoMaBL(string ma)
        {
            string makh = (from bl in db.BIENLAIs
                          where bl.MAGD == ma
                          select bl.MAKH).FirstOrDefault();

            IQueryable KH = from kh in db.KHACHHANGs
                            where kh.MAKH == makh
                            select kh.TENKH;
            return KH;
        }

        //hàm lấy số tài khoản theo tên
        public IQueryable LaySoTKTheoTen(string ten)
        {
            string ma = (from kh in db.KHACHHANGs
                        where kh.TENKH == ten
                        select kh.MAKH).FirstOrDefault();

            IQueryable SOTK = from tk in db.TAIKHOANs
                              where tk.MAKH == ma
                              select tk.SOTAIKHOAN;
            return SOTK;
        }

        //hàm lấy danh sách số tiền theo số tài khoản
        public IQueryable LayDSSoTienTheoSTK(string stk)
        {
            string matk = (from tk in db.TAIKHOANs
                          where tk.SOTAIKHOAN == stk
                          select tk.MATK).FirstOrDefault();

            IQueryable SOTien = from gd in db.GIAODICHes
                              where gd.MATK == matk
                              select gd.SOTIEN;
            return SOTien;
        }

        //hàm lấy tên loại tiền theo số tài khoản
        public IQueryable LayTenLoaiTienTheoSTK(string stk)
        {
            string malt = (from tk in db.TAIKHOANs
                           where tk.SOTAIKHOAN == stk
                           select tk.MALOAITIEN).FirstOrDefault();

            IQueryable TenLT = from lt in db.LOAITIENs
                                where lt.MALOAITIEN == malt
                               select lt.TENLOAITIEN;
            return TenLT;
        }

        //hàm lấy tên danh sách tên nhân viên
        public IQueryable LayDSTenNV()
        {
            IQueryable TenNV = from nv in db.NHANVIENs
                               select nv.TENNV;
            return TenNV;
        }

        //hàm lấy tên nhân viên theo mã
        public string LayTenNVTheoMa(string ma)
        {
            string ten = (from nv in db.NHANVIENs
                         where nv.MANV == ma
                         select nv.TENNV).FirstOrDefault();
            return ten;
        }

        //hàm lấy tên khách hàng theo mã khách hàng
        public string LayTenKHTheoMaKH(string ma)
        {
            string ten = (from kh in db.KHACHHANGs
                         where kh.MAKH == ma
                         select kh.TENKH).FirstOrDefault();
            return ten;
        }

        //hàm lấy số tài khoản theo mã tài khoản
        public string LaySoTKTheoMaTK(string ma)
        {
            string sotk = (from tk in db.TAIKHOANs
                          where tk.MATK == ma
                          select tk.SOTAIKHOAN).FirstOrDefault();
            return sotk;
        }

        //hàm lấy tên loại tiền theo mã loại tiền
        public string LayTenLTTheoMaLT(string ma)
        {
            string ten = (from lt in db.LOAITIENs
                         where lt.MALOAITIEN == ma
                         select lt.TENLOAITIEN).FirstOrDefault();
            return ten;
        }

        //hàm lấy mã khách hàng theo tên
        public string LayMaKHTheoTen(string ten)
        {
            string ma = (from kh in db.KHACHHANGs
                         where kh.TENKH == ten
                         select kh.MAKH).FirstOrDefault();
            return ma;
        }

        //hàm lấy mã tài khoản theo số tài khoản
        public string LayMaTKTheoSo(string so)
        {
            string ma = (from tk in db.TAIKHOANs
                         where tk.SOTAIKHOAN == so
                         select tk.MATK).FirstOrDefault();
            return ma;
        }

        //hàm lấy mã nhân viên theo tên 
        public string LayMaNVTheoTen(string ten)
        {
            string ma = (from nv in db.NHANVIENs
                         where nv.TENNV == ten
                         select nv.MANV).FirstOrDefault();
            return ma;
        }

        //hàm lấy mã loại tiền theo tên
        public string LayMaLoaiTienTheoTen(string ten)
        {
            string ma = (from lt in db.LOAITIENs
                         where lt.TENLOAITIEN == ten
                         select lt.MALOAITIEN).FirstOrDefault();
            return ma;
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
                File.AppendAllText(@"D:\log.txt", ex.ToString());
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
