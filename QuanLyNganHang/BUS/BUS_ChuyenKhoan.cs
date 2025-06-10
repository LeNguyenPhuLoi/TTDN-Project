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

        //lấy danh sách chuyển khoản
        public IQueryable LoadDSTK()
        {
            return chuyenKhoan.LayDSChuyenKhoan();
        }

        //thêm chuyển khoản
        public bool ThemChuyenKhoan(ET_ChuyenKhoan et)
        {
            return chuyenKhoan.ThemChuyenKhoan(et);
        }

        //cập nhật chuyển khoản
        public bool CapNhatChuyenKhoan(ET_ChuyenKhoan et)
        {
            return chuyenKhoan.CapNhapChuyenKhoan(et);
        }

        //xóa chuyển khoản
        public bool XoaChuyenKhoan(ET_ChuyenKhoan et)
        {
            return chuyenKhoan.XoaChuyenKhoan(et);
        }
    }
}
