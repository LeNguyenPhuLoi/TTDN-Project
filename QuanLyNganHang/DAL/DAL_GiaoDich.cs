using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_GiaoDich
    {
        //kết nối với database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_GiaoDich()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách giao dịch
        public IQueryable LayDSGiaoDich()
        {
            IQueryable GD = from gd in db.GIAODICHes
                            select gd;
            return GD;
        }

        //hàm lấy số tài khoản
        public IQueryable LaySoTK()
        {
            IQueryable sotk = from tk in db.TAIKHOANs
                              select tk.SOTAIKHOAN;
            return sotk;
        }

        //hàm tìm giao dịch thep mã
        public IQueryable TimGDTheoMa(string ma)
        {
            IQueryable GD = from gd in db.GIAODICHes
                            where gd.MAGD.Contains(ma)
                            select gd;
            return GD;
        }

        //hàm tìm giao dịch theo số tài khoản
        public IQueryable TimGDTheoSTK(string stk)
        {
            IQueryable GD = from gd in db.GIAODICHes
                            where gd.MATK.Contains(LayMaTKTheoSo(stk))
                            select gd;
            return GD;
        }

        //hàm tìm giao dịch theo loại giao dịch
        public IQueryable TimGDTheoLoai(string loai)
        {
            IQueryable GD = from gd in db.GIAODICHes
                            where gd.LOAIGD.Contains(loai)
                            select gd;
            return GD;
        }

        //hàm kiểm tra số tiền trong tài khoản
        public bool KTTienTrongTK(string sotk, decimal sotiengd)
        {
            decimal sotientk = (decimal)(from tk in db.TAIKHOANs
                                       where tk.SOTAIKHOAN == sotk
                                       select tk.SODU).FirstOrDefault();
            if(sotiengd > sotientk)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //hàm trừ tiền trong tài khoản
        public void TruTien(decimal sotiendg, string sotk)
        {
            try
            {
                var update = db.TAIKHOANs.SingleOrDefault(x => x.SOTAIKHOAN == sotk);
                if (update != null)
                {
                    update.SODU = (update.SODU - sotiendg);

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
        }

        //hàm lấy mã tài khoản theo số tài khoản
        public string LayMaTKTheoSo(string so)
        {
            string ma = (from tk in db.TAIKHOANs
                        where tk.SOTAIKHOAN == so
                        select tk.MATK).FirstOrDefault();
            return ma;
        }

        //hàm lấy số tài khoản theo mã tài khoản
        public string LaySoTKTheoMa(string ma)
        {
            string so = (from tk in db.TAIKHOANs
                         where tk.MATK == ma
                         select tk.SOTAIKHOAN).FirstOrDefault();
            return so;
        }

        //hàm thêm tiền vào lại tài khoản khi xóa
        public void ThemTienVaoLaiTK(decimal sotiengd, string sotk)
        {
            try
            {
                var update = db.TAIKHOANs.SingleOrDefault(x => x.SOTAIKHOAN == sotk);
                if (update != null)
                {
                    update.SODU = (update.SODU + sotiengd);

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
        }

        //hàm thêm giao dịch
        public bool ThemGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;
            try
            {
                var exist = db.GIAODICHes.Any(x => x.MAGD == et.LoaiGD);
                if (!exist)
                {
                    GIAODICH gd = new GIAODICH()
                    {
                        MAGD = et.MaGD,
                        MATK = et.MaTK,
                        LOAIGD = et.LoaiGD,
                        SOTIEN = et.SoTien,
                        THOIGIANGD = et.ThoiGianGD,
                        MOTA = et.MoTa,
                        TRANGTHAI = et.TrangThai
                    };
                    db.GIAODICHes.InsertOnSubmit(gd);
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

        //hàm sửa thông tin giao dịch
        public bool SuaGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;
            try
            {
                var update = db.GIAODICHes.SingleOrDefault(x => x.MAGD == et.MaGD);
                if(update != null)
                {
                    update.MATK = et.MaTK;
                    update.LOAIGD = et.LoaiGD;
                    update.SOTIEN = et.SoTien;
                    update.THOIGIANGD = et.ThoiGianGD;
                    update.MOTA = et.MoTa;
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

        //hàm xóa giao dịch
        public bool XoaGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;
            try
            {
                var gd = db.GIAODICHes.SingleOrDefault(x => x.MAGD == et.MaGD);
                if (gd != null)
                {
                    db.GIAODICHes.DeleteOnSubmit(gd);
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
