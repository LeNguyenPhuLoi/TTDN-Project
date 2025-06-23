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

        //hàm tìm khách hàng theo mã
        public IQueryable TimKHTheoMa(string ma)
        {
            return kh.TimKHTheoMa(ma);
        }

        //hàm tìm khách hàng theo tên
        public IQueryable TimKHTheoTen(string ten)
        {
            return kh.TimKHTheoTen(ten);
        }

        //hàm tìm khách hàng theo CCCD/CMND
        public IQueryable TimKHTheoCCCD(string cccd)
        {
            return kh.TimKHTheoCCCD(cccd);
        }

        //hàm tìm khách hàng theo SDT
        public IQueryable TimKHTheoSDT(string sdt)
        {
            return kh.TimKHTheoSDT(sdt);
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
