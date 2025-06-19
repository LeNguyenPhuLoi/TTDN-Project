using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai km = new DAL_KhuyenMai();

        // Lấy danh sách khuyến mãi
        public IQueryable LoadDSKhuyenMai()
        {
            return km.LoadKM();
        }

        // Thêm khuyến mãi
        public bool ThemKhuyenMai(ET_KhuyenMai et, out string error )
        {
            return km.ThemKM(et,out error);
        }

        // Cập nhật khuyến mãi
        public bool CapNhatKhuyenMai(ET_KhuyenMai et, out string error)
        {
            return km.SuaKM(et, out error);
        }

        // Xóa khuyến mãi
        public bool XoaKhuyenMai(ET_KhuyenMai et, out string error)
        {
            return km.XoaKM(et, out error);
        }
    }
}
