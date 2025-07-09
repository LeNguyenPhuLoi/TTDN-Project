using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiTienRP
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTienRP lt = new DAL_LoaiTienRP();

        //gọi hàm lấy danh sách loại tiền cho report
        public List<ET_LoaiTienRP> LoadDSLoaiTien()
        {
            return lt.LoadDSLoaiTien();
        }

        //gọi hàm lấy danh sách loại tiền cho report theo mã
        public List<ET_LoaiTienRP> LoadDSLoaiTienTheoMa(string ma)
        {
            return lt.LoadDSLoaiTienTheoMa(ma);
        }

        //gọi hàm lấy danh sách loại tiền cho report theo tên
        public List<ET_LoaiTienRP> LoadDSLoaiTienTheoTen(string ten)
        {
            return lt.LoadDSLoaiTienTheoTen(ten);
        }

        //gọi hàm lấy danh sách loại tiền cho report theo quốc gia
        public List<ET_LoaiTienRP> LoadDSLoaiTienTheoQG(string qg)
        {
            return lt.LoadDSLoaiTienTheoQG(qg);
        }
    }

    public class BUS_LoaiTien
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTien lt = new DAL_LoaiTien();

        //gọi hàm LayDSLoaiTien từ DAL
        public IQueryable LayDSLoaiTien()
        {
            return lt.LayDSLoaiTien();
        }

        //hàm tìm loại tiền theo mã
        public IQueryable TimLoaiTienTheoMa(string ma)
        {
            return lt.TimLoaiTienTheoMa(ma);
        }

        //hàm tìm loại tiền theo tên
        public IQueryable TimLoaiTienTheoTen(string ten)
        {
            return lt.TimLoaiTienTheoTen(ten);
        }

        //hàm tìm loại tiền theo quốc gia
        public IQueryable TimLoaiTienTheoQG(string qg)
        {
            return lt.TimLoaiTienTheoQG(qg);
        }

        //gọi hàm ThemLoaiTien từ DAL
        public bool ThemLoaiTien(ET_LoaiTien et)
        {
            return lt.ThemLoaiTien(et);
        }

        //gọi hàm SuaThongTinLoaiTien từ DAL
        public bool SuaThongTinLoaiTien(ET_LoaiTien et)
        {
            return lt.SuaThongTinLoaiTien(et);
        }

        //gọi hàm XoaLoaiTien từ DAL
        public bool XoaLoaiTien(ET_LoaiTien et)
        {
            return lt.XoaLoaiTien(et);
        }
    }
}
