using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_ApDungKhuyenMai
    {
        DAL_ApDungKhuyenMai adkm = new DAL.DAL_ApDungKhuyenMai();

        // Lấy danh sách áp dụng khuyến mãi
        public IQueryable LoadDSApDungKhuyenMai()
        {
            return adkm.LoadKhuyenMai();
        }

        //Tìm kiếm áp dụng khuyến mãi
        public IQueryable TimKiemApDungKhuyenMai(string keyword)
        {
            return adkm.TimKiemADKM(keyword);
        }

        // Lấy danh sách khách hàng
        public IQueryable LoadDSKhachHang()
        {
            return adkm.LoadDSKH();
        }

        // Lấy danh sách tài khoản
        public IQueryable LoadDSKM()
        {
            return adkm.LoadDSKM();
        }

        // Thêm áp dụng khuyến mãi
        public bool ThemApDungKhuyenMai(ET_ApDungKhuyenMai et, out string error)
        {
            return adkm.ThemApDungKhuyenMai(et,out error);
        }

        // Cập nhật áp dụng khuyến mãi
        public bool CapNhatApDungKhuyenMai(ET_ApDungKhuyenMai et, out string error)
        {
            return adkm.CapNhatApDungKhuyenMai(et, out error);
        }

        // Xóa áp dụng khuyến mãi
        public bool XoaApDungKhuyenMai(ET_ApDungKhuyenMai et, out string error)
        {
            return adkm.XoaApDungKhuyenMai(et, out error);
        }
    }
}
