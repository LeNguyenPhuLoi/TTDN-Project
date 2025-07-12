using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_BienLaiRP
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_BienLaiRP bl = new DAL_BienLaiRP();

        //gọi hàm lấy danh sách biên lai cho report
        public List<ET_BienLaiRP> LoadDSBienLai()
        {
            return bl.LoadDSBienLai();
        }

        //gọi hàm lấy danh sách biên lai cho report theo mã biên lai
        public List<ET_BienLaiRP> LoadDSBienLaiTheoMa(string ma)
        {
            return bl.LoadDSBienLaiTheoMa(ma);
        }

        //gọi hàm lấy danh sách biên lai cho report theo tên khách hàng
        public List<ET_BienLaiRP> LoadDSBienLaiTheoTenKH(string ten)
        {
            return bl.LoadDSBienLaiTheoTenKH(ten);
        }

        //gọi hàm lấy danh sách biên lai cho report theo số tài khoản
        public List<ET_BienLaiRP> LoadDSBienLaiTheoSTK(string stk)
        {
            return bl.LoadDSBienLaiTheoSTK(stk);
        }
    }

        public class BUS_BienLai
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_BienLai bl = new DAL_BienLai();

        //gọi hàm LayDSBienLai từ DAL
        public IQueryable LayDSBienLai()
        {
            return bl.LayDSBienLai();
        }


        //gọi hàm tìm biên lai theo mã biên lai
        public IQueryable TimBLTheoMaBl(string ma)
        {
            return bl.TimBLTheoMaBl(ma);
        }

        //gọi hàm tìm biên lai theo mã giao dịch
        public IQueryable TimBLTheoMaGD(string ma)
        {
            return bl.TimBLTheoMaGD(ma);
        }

        //gọi hàm tìm biên lai theo tên khách hàng
        public IQueryable TimBLTheoTenKH(string ten)
        {
            return bl.TimBLTheoTenKH(ten);
        }

        //gọi hàm tìm biên lai theo số tài khoản
        public IQueryable TimBLTheoSTK(string stk)
        {
            return bl.TimBLTheoSTK(stk);
        }

        //gọi hàm lấy số tài khoản
        public IQueryable LaySTK()
        {
            return bl.LaySTK();
        }

        //gọi hàm lấy tên khách hàng
        public IQueryable LayTenKH()
        {
            return bl.LayTenKH();
        }

        //gọi hàm lấy mã giao dịch
        public IQueryable LayMaGD()
        {
            return bl.LayMaGD();
        }

        //gọi hàm lấy tên khách hàng
        public IQueryable LayTenKHTheoMaBL(string ma)
        {
            return bl.LayTenKHTheoMaBL(ma);
        }

        //gọi hàm lấy số tài khoản theo mã
        public IQueryable LaySoTKTheoTen(string ten)
        {
            return bl.LaySoTKTheoTen(ten);
        }

        //gọi hàm lấy danh sách số tiền theo số tài khoản
        public IQueryable LayDSSoTienTheoSTK(string stk)
        {
            return bl.LayDSSoTienTheoSTK(stk);
        }

        //gọi hàm lấy tên loại tiền theo số tài khoản
        public IQueryable LayTenLoaiTienTheoSTK(string stk)
        {
            return bl.LayTenLoaiTienTheoSTK(stk);
        }

        //gọi hàm lấy tên danh sách tên nhân viên
        public IQueryable LayDSTenNV()
        {
            return bl.LayDSTenNV();
        }

        //gọi hàm lấy tên nhân viên theo mã
        public string LayTenNVTheoMa(string ma)
        {
            return bl.LayTenNVTheoMa(ma);
        }

        //gọi hàm lấy tên khách hàng theo mã khách hàng
        public string LayTenKHTheoMaKH(string ma)
        {
            return bl.LayTenKHTheoMaKH(ma);
        }

        //gọi hàm lấy số tài khoản theo mã tài khoản
        public string LaySoTKTheoMaTK(string ma)
        {
            return bl.LaySoTKTheoMaTK(ma);
        }

        //gọi hàm lấy tên loại tiền theo mã loại tiền
        public string LayTenLTTheoMaLT(string ma)
        {
            return bl.LayTenLTTheoMaLT(ma);
        }

        //gọi hàm lấy mã khách hàng theo tên
        public string LayMaKHTheoTen(string ten)
        {
            return bl.LayMaKHTheoTen(ten);
        }

        //gọi hàm lấy mã tài khoản theo số tài khoản
        public string LayMaTKTheoSo(string so)
        {
            return bl.LayMaTKTheoSo(so);
        }

        //gọi hàm lấy mã nhân viên theo tên 
        public string LayMaNVTheoTen(string ten)
        {
            return bl.LayMaNVTheoTen(ten);   
        }

        //gọi hàm lấy mã loại tiền theo tên
        public string LayMaLoaiTienTheoTen(string ten)
        {
            return bl.LayMaLoaiTienTheoTen(ten);
        }


        //gọi hàm ThemBienLai từ DAL
        public bool ThemBienLai(ET_BienLai et)
        {
            return bl.ThemBienLai(et);
        }

        //gọi hàm SuaBienLai từ DAL
        public bool SuaBienLai(ET_BienLai et)
        {
            return bl.SuaBienLai(et);
        }

        //gọi hàm XoaBienLai từ DAL
        public bool XoaBienLai(ET_BienLai et)
        {
            return bl.XoaBienLai(et);
        }
    }
}
