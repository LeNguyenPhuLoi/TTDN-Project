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

        // Thêm áp dụng khuyến mãi
        public bool ThemApDungKhuyenMai(ET_ApDungKhuyenMai et)
        {
            return adkm.ThemApDungKhuyenMai(et);
        }

        // Cập nhật áp dụng khuyến mãi
        public bool CapNhatApDungKhuyenMai(ET_ApDungKhuyenMai et)
        {
            return adkm.CapNhatApDungKhuyenMai(et);
        }

        // Xóa áp dụng khuyến mãi
        public bool XoaApDungKhuyenMai(ET_ApDungKhuyenMai et)
        {
            return adkm.XoaApDungKhuyenMai(et);
        }
    }
}
