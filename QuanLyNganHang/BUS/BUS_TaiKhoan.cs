using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_TaiKhoan tk = new DAL_TaiKhoan();

        //gọi hàm LayDSTaiKhoan từ DAL
        public IQueryable LayDSTaiKhoan()
        {
            return tk.LayDSTaiKhoan();
        }

        //gọi hàm ThemTaiKhoan từ DAL
        public bool ThemTaiKhoan(ET_TaiKhoan et)
        {
            return tk.ThemTaiKhoan(et);
        }

        //gọi hàm SuaTaiKhoan từ DAL
        public bool SuaTaiKhoan(ET_TaiKhoan et)
        {
            return tk.SuaTaiKhoan(et);
        }

        //gọi hàm XoaTaiKhoan từ DAL
        public bool XoaTaiKhoan(ET_TaiKhoan et)
        {
            return tk.XoaTaiKhoan(et);
        }
    }
}
