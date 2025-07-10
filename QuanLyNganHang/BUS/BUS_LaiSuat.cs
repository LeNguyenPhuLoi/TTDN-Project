using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BUS
{
    public class BUS_LaiSuat
    {
        DAL_LaiSuat ls = new DAL_LaiSuat();

        // Lấy danh sách lãi suất
        public IQueryable LoadDSLaiSuat()
        {
            return ls.LoadLaiSuat();
        }

        // Thêm lãi suất
        public bool ThemLaiSuat(ET.ET_LaiSuat et, out string error)
        {
            return ls.ThemLaiSuat(et,out error);
        }

        // Cập nhật lãi suất
        public bool CapNhatLaiSuat(ET.ET_LaiSuat et, out string error)
        {
            return ls.CapNhatLaiSuat(et, out error);
        }

        // Xóa lãi suất
        public bool XoaLaiSuat(ET.ET_LaiSuat et, out string error)
        {
            return ls.XoaLaiSuat(et, out error);
        }
    }
}
