using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhoanVay
    {
        DAL_KhoanVay kv = new DAL_KhoanVay();

        // Lấy danh sách khoản vay
        public IQueryable LoadDSKhoanVay()
        {
            return kv.LoadKhoanVay();
        }

        // lay danh sách khách hàng
        public IQueryable LoadTenKhachHang()
        {
            return kv.LoadTenKhachHang();
        }

        // Lấy mã khách hàng theo tên
        public string GetMaKhachHang(string tenKhachHang)
        {
            return kv.GetMaKhachHang(tenKhachHang);
        }

        // Lấy tên khách hàng theo mã
        public string GetTenKhachHang(string maKhachHang)
        {
            return kv.GetTenKhachHang(maKhachHang);
        }


        // Thêm khoản vay
        public bool ThemKhoanVay(ET.ET_KhoanVay et,out string error)
        {
            return kv.ThemKhoanVay(et, out error);
        }

        // Cập nhật khoản vay
        public bool CapNhatKhoanVay(ET.ET_KhoanVay et,out string error)
        {
            return kv.CapNhatKhoanVay(et, out error);
        }

        // Xóa khoản vay
        public bool XoaKhoanVay(ET.ET_KhoanVay et, out string error)
        {
            return kv.XoaKhoanVay(et, out error);
        }

        //tìm kiem khoản vay
        public IQueryable TimKiemKhoanVay(string maKhoanVay)
        {
            return kv.TimKiemKhoanVay(maKhoanVay);
        }

        
    }
    public class BUS_KhoanVay_RP
    {
        DAL_KhoanVayRP kv = new DAL_KhoanVayRP();

        // Lấy danh sách khoản vay để báo cáo
        public List<ET_KhoanVay_RP> LoadKhoanVayRP()
        {
            return kv.LoadDSKhoanVay();
        }

        //tim kiếm khoản vay de bao cáo
        public List<ET_KhoanVay_RP> TimKiemKhoanVayRP(string keyword)
        {
            return kv.TimRPKhoanVay(keyword);
        }
    }
}
