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
        //gọi Hàm lấy danh sách loại tài khoản
        public IQueryable LayDSLoaiTaiKhoan()
        {
            return tk.LayDSLoaiTaiKhoan();
        }
        //gọi Hàm lấy danh sách tên loại tiền
        public IQueryable LayDSTenLoaiTien()
        {
            return tk.LayDSTenLoaiTien();
        }

        //gọi hàm lấy danh sách tên khách hàng
        public IQueryable LayDSTenKH()
        {
            return tk.LayDSTenKH();
        }

        //gọi hàm tìm tài khoản theo mã tài khoản
        public IQueryable TimTKTheoMaTK(string ma)
        {
            return tk.TimTKTheoMaTK(ma);
        }

        //gọi hàm tìm tài khoản theo tên khách hàng
        public IQueryable TimTKTheoTenKH(string tenkh)
        {
            return tk.TimTKTheoTenKH(tenkh);
        }

        //gọi hàm tìm tài khoản theo số tài khoản
        public IQueryable TimTKTheoSTK(string stk)
        {
            return tk.TimTKTheoSTK(stk);
        }

        //gọi hàm lấy mã khách hàng theo tên
        public string LayMaKHTheoTen(string ten)
        {
            return tk.LayMaKHTheoTen(ten);
        }

        //gọi hàm lấy mã loại tài khoản theo chi tiết
        public string LayMaLTKTheoChiTiet(string chitiet)
        {
            return tk.LayMaLTKTheoChiTiet(chitiet);
        }

        //gọi hàm lấy mã loại tiền theo tên
        public string LayMaLTTheoTen(string ten)
        {
            return tk.LayMaLTTheoTen(ten);
        }

        //gọi hàm lấy tên khách hàng theo mã
        public string LayTenKHTheoMa(string ma)
        {
            return tk.LayTenKHTheoMa(ma);
        }

        //hàm lấy chi tiết theo mã loại tài khoản
        public string LayChiTietTheoMaLTK(string ma)
        {
            return tk.LayChiTietTheoMaLTK(ma);
        }

        //hàm lấy tên theo mã loại tiền
        public string LayTenTheoMaLT(string ma)
        {
            return tk.LayTenTheoMaLT(ma);
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
