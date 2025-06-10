using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        MAKH = et.MaTK,
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
