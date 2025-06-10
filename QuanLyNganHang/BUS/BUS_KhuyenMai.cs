using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai km = new DAL.DAL_KhuyenMai();

        // Lấy danh sách khuyến mãi
        public IQueryable LoadDSKhuyenMai()
        {
            return km.LoadKM();
        }

        // Thêm khuyến mãi
        public bool ThemKhuyenMai(ET.ET_KhuyenMai et)
        {
            return km.ThemKM(et);
        }

        // Cập nhật khuyến mãi
        public bool CapNhatKhuyenMai(ET.ET_KhuyenMai et)
        {
            return km.SuaKM(et);
        }

        // Xóa khuyến mãi
        public bool XoaKhuyenMai(ET.ET_KhuyenMai et)
        {
            return km.XoaKM(et);
        }
    }
}
