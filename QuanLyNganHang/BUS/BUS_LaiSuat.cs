using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool ThemLaiSuat(ET.ET_LaiSuat et)
        {
            return ls.ThemLaiSuat(et);
        }

        // Cập nhật lãi suất
        public bool CapNhatLaiSuat(ET.ET_LaiSuat et)
        {
            return ls.CapNhatLaiSuat(et);
        }

        // Xóa lãi suất
        public bool XoaLaiSuat(ET.ET_LaiSuat et)
        {
            return ls.XoaLaiSuat(et);
        }
}
