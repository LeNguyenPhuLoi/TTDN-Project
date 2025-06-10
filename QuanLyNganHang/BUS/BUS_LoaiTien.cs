using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiTien
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTien lt = new DAL_LoaiTien();

        //gọi hàm LayDSLoaiTien từ DAL
        public IQueryable LayDSLoaiTien()
        {
            return lt.LayDSLoaiTien();
        }

        //gọi hàm ThemLoaiTien từ DAL
        public bool ThemLoaiTien(ET_LoaiTien et)
        {
            return lt.ThemLoaiTien(et);
        }

        //gọi hàm SuaThongTinLoaiTien từ DAL
        public bool SuaThongTinLoaiTien(ET_LoaiTien et)
        {
            return lt.SuaThongTinLoaiTien(et);
        }

        //gọi hàm XoaLoaiTien từ DAL
        public bool XoaLoaiTien(ET_LoaiTien et)
        {
            return lt.XoaLoaiTien(et);
        }
    }
}
