using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_ChuyenKhoan
    {
        DAL_ChuyenKhoan chuyenKhoan = new DAL_ChuyenKhoan();

        //lấy danh sách tài khoản
        public IQueryable LoadMaTK()
        {
            return chuyenKhoan.LoadDSTK();
        }

        //lấy danh sách chuyển khoản
        public IQueryable LoadDSTK()
        {
            return chuyenKhoan.LayDSChuyenKhoan();
        }

        //thêm chuyển khoản
        public bool ThemChuyenKhoan(ET_ChuyenKhoan et, out string error)
        {
            return chuyenKhoan.ThemChuyenKhoan(et, out error);
        }

        //cập nhật chuyển khoản
        public bool CapNhatChuyenKhoan(ET_ChuyenKhoan et,out string error)
        {
            return chuyenKhoan.CapNhapChuyenKhoan(et, out error);
        }

        //xóa chuyển khoản
        public bool XoaChuyenKhoan(ET_ChuyenKhoan et, out string error)
        {
            return chuyenKhoan.XoaChuyenKhoan(et,out error);
        }
    }
}
