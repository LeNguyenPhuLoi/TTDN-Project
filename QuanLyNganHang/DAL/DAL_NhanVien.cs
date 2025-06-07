using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_NhanVien
    {
        //Kết nối với Linq to SQL
        QLNHDataContext db = new QLNHDataContext();

        //Lấy ds nhân viên
        public IQueryable LoadDSNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select nv;
            return NV;
        }

        //Thêm nhân viên
        public bool ThemNV(ET_NhanVien et)
        {
            bool ss = false;
            try
            {
                var amp = db.NHANVIENs.Any(nv => nv.MANV == et.MaNV);
                if (!amp)
                {
                    NHANVIEN nv = new NHANVIEN
                    {
                        MANV = et.MaNV,
                        TENNV = et.TenNV,
                        GIOITINH = et.GioiTinh,
                        NGAYSINH = et.NgaySinh,
                        CHUC = et.Chuc,
                        LUONG = et.Luong,
                        DIACHI = et.DiaChi,
                        SDT = et.Sdt,
                        MAPB = et.MaPB,
                        MACN = et.MaCN
                    };
                    db.NHANVIENs.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Sửa nhân viên
        public bool SuaNV(ET_NhanVien et)
        {
            bool ss = false;
            try
            {
                var change = db.NHANVIENs.SingleOrDefault(nv => nv.MANV == et.MaNV);
                if (change != null)
                {
                    change.MANV = et.MaNV;
                    change.TENNV = et.TenNV;
                    change.GIOITINH = et.GioiTinh;
                    change.NGAYSINH = et.NgaySinh;
                    change.CHUC = et.Chuc;
                    change.LUONG = et.Luong;
                    change.DIACHI = et.DiaChi;
                    change.SDT = et.Sdt;
                    change.MAPB = et.MaPB;
                    change.MACN = et.MaCN;

                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Xóa nhân viên
        public bool XoaNV(ET_NhanVien et)
        {
            bool ss = false;
            try
            {
                var delete = db.NHANVIENs.SingleOrDefault(nv => nv.MANV == et.MaNV);
                if(delete != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }
    }
}
