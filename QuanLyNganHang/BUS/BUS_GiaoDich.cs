using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_GiaoDich
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_GiaoDich gd = new DAL_GiaoDich();

        //gọi hàm LayDSGiaoDich từ DAL
        public IQueryable LayDSGiaoDich()
        {
            return gd.LayDSGiaoDich();
        }

        //gọi hàm ThemGiaoDich từ DAL
        public bool ThemGiaoDich(ET_GiaoDich et)
        {
            return gd.ThemGiaoDich(et);
        }

        //gọi hàm SuaGiaoDich từ DAL
        public bool SuaGiaoDich(ET_GiaoDich et)
        {
            return gd.SuaGiaoDich(et);
        }

        //gọi hàm XoaGiaoDich từ DAL
        public bool XoaGiaoDich(ET_GiaoDich et)
        {
            return gd.XoaGiaoDich(et);
        }
    }
}
