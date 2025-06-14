using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TKDangNhap
    {
        DAL_TaiKhoanDangNhap login = new DAL_TaiKhoanDangNhap();

        // Lấy danh sách tài khoản đăng nhập
        public IQueryable LoadTKL()
        {
            return login.LayDSTaiKhoanDangNhap();
        }

        // Lấy danh sách nhân viên
        public IQueryable LoadDSNV()
        {
            return login.LoadNhanVien();
        }

        // Thêm tài khoản đăng nhập
        public bool ThemTKL(ET_DangNhap et)
        {
            return login.ThemTaiKhoanDN(et);
        }

        // Cập nhật tài khoản đăng nhập
        public bool CapNhatTKL(ET_DangNhap et)
        {
            return login.CapNhapTKDN(et);
        }

        // Xóa tài khoản đăng nhập
        public bool XoaTKL(ET_DangNhap et)
        {
            return login.XoaTKDN(et);
        }
    }
}
