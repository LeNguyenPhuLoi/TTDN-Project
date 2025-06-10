using DAL;
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

        // Thêm khoản vay
        public bool ThemKhoanVay(ET.ET_KhoanVay et)
        {
            return kv.ThemKhoanVay(et);
        }

        // Cập nhật khoản vay
        public bool CapNhatKhoanVay(ET.ET_KhoanVay et)
        {
            return kv.CapNhatKhoanVay(et);
        }

        // Xóa khoản vay
        public bool XoaKhoanVay(ET.ET_KhoanVay et)
        {
            return kv.XoaKhoanVay(et);
        }
    }
}
