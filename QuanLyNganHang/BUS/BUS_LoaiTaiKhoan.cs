using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiTaiKhoan
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTaiKhoan ltk = new DAL_LoaiTaiKhoan();

        //gọi hàm LoadDSLoaiTaiKhoan từ DAL
        public IQueryable LoadDSLoaiTaiKhoan()
        {
            return ltk.LoadDSLoaiTaiKhoan();
        }

        //gọi hàm ThemLoaiTaiKhoan từ DAL
        public bool ThemLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return ltk.ThemLoaiTaiKhoan(et);
        }

        //gọi hàm SuaThongTinLoaiTaiKhoan từ DAL
        public bool SuaThongTinLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return ltk.SuaThongTinLoaiTaiKhoan(et);
        }

        //gọi hàm XoaLoaiTaiKhoan từ DAL
        public bool XoaLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return ltk.XoaLoaiTaiKhoan(et);
        }
    }
}
