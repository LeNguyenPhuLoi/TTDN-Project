using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_KhachHang
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_KhachHang kh = new DAL_KhachHang();

        //gọi hàm LoadDSKhachHang từ DAL
        public IQueryable LoadDSKhachHang()
        {
            return kh.LoadDSKhachHang();
        }

        //gọi hàm ThemKhachHang từ DAL
        public bool ThemKhachHang(ET_KhachHang et)
        {
            return kh.ThemKhachHang(et);
        }

        //gọi hàm SuaThongTinKhachHang từ DAL
        public bool SuaThongTinKhachHang(ET_KhachHang et)
        {
            return kh.SuaThongTinKhachHang(et);
        }

        //gọi hàm XoaKhachHang từ DAL
        public bool XoaKhachHang(ET_KhachHang et)
        {
            return kh.XoaKhachHang(et);
        }
    }
}
