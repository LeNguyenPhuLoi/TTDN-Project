using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiTaiKhoanRP
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTaiKhoanRP ltk = new DAL_LoaiTaiKhoanRP();

        //gọi hàm lấy danh sách loại tài khoản cho report
        public List<ET_LoaiTaiKhoanRP> LoadDSLoaiTaiKhoan()
        {
            return ltk.LoadDSLoaiTaiKhoan();
        }

        //gọi hàm lấy danh sách loại tài khoản cho report theo mã
        public List<ET_LoaiTaiKhoanRP> LoadDSLoaiTaiKhoanTheoMa(string ma)
        {
            return ltk.LoadDSLoaiTaiKhoanTheoMa(ma);
        }

        //hàm lấy danh sách loại tài khoản cho report theo chi tiết
        public List<ET_LoaiTaiKhoanRP> LoadDSLoaiTaiKhoanTheoChiTiet(string chitiet)
        {
            return ltk.LoadDSLoaiTaiKhoanTheoChiTiet(chitiet);
        }
    }
        
    public class BUS_LoaiTaiKhoan
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTaiKhoan ltk = new DAL_LoaiTaiKhoan();

        //gọi hàm LoadDSLoaiTaiKhoan từ DAL
        public IQueryable LoadDSLoaiTaiKhoan()
        {
            return ltk.LoadDSLoaiTaiKhoan();
        }

        //gọi hàm tìm loại tài khoản theo mã
        public IQueryable LayLTKTheoMa(string ma)
        {
            return ltk.LayLTKTheoMa(ma);
        }

        //gọi hàm tìm loại tài khoản theo chi tiết
        public IQueryable LayLTKTheoChiTiet(string chitiet)
        {
            return ltk.LayLTKTheoChiTiet(chitiet);
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
