using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_KhachHang
    {
        //kết nối database = linq to sql
        QLNHDataContext db = new QLNHDataContext();

        //Hàm lấy danh sách khách hàng
        public IQueryable LoadDSKhachHang()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select kh;
            return KH;
        }

        //hàm thêm khách hàng
        public bool ThemKhachHang(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                var exist = db.KHACHHANGs.Any(kh => kh.MAKH == et.MaKH);
                if (!exist) 
                {
                    KHACHHANG kh = new KHACHHANG()
                    {
                        MAKH = et.MaKH,
                        TENKH = et.TenKH,
                        GIOITINH = et.GioiTinh,
                        CCCD = et.Cccd,
                        SDT = et.Sdt,
                        EMAIL = et.Email,
                        DIACHI = et.DiaChi,
                        QUOCTICH = et.QuocTich,
                        DOITUONG = et.DoiTuong,
                        NGAYTAO = et.NgayTao
                    };
                    db.KHACHHANGs.InsertOnSubmit(kh);
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

        //hàm sửa thông tin khách hàng
        public bool SuaThongTinKhachHang(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                var update = db.KHACHHANGs.SingleOrDefault(kh => kh.MAKH == et.MaKH);
                if (update != null)
                {
                    update.TENKH = et.MaKH;
                    update.GIOITINH = et.GioiTinh;
                    update.CCCD = et.Cccd;
                    update.SDT = et.Sdt;
                    update.EMAIL = et.Email;
                    update.DIACHI = et.DiaChi;
                    update.QUOCTICH = et.QuocTich;
                    update.DOITUONG = et.DoiTuong;
                    update.NGAYTAO = et.NgayTao;

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

        //hàm xóa khách hàng
        public bool XoaKhachHang(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                var kh = db.KHACHHANGs.SingleOrDefault(n => n.MAKH == et.MaKH);
                if (kh != null) 
                {
                    db.KHACHHANGs.DeleteOnSubmit(kh);
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
