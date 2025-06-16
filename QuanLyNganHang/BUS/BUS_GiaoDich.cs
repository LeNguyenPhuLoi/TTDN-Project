using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_GiaoDich
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_GiaoDich gd = new DAL_GiaoDich();

        //gọi hàm LayDSGiaoDich từ DAL
        public IQueryable LayDSGiaoDich()
        {
            return gd.LayDSGiaoDich();
        }

        //gọi hàm lấy số tài khoản
        public IQueryable LaySoTK()
        {
            return gd.LaySoTK();
        }

        //gọi hàm kiểm tra số tiền trong tài khoản
        public bool KTTienTrongTK(string sotk, decimal sotiengd)
        {
            return gd.KTTienTrongTK(sotk, sotiengd);
        }

        //gọi hàm lấy mã tài khoản theo số tài khoản
        public string LayMaTKTheoSo(string so)
        {
            return gd.LayMaTKTheoSo(so);
        }

        //gọi hàm lấy số tài khoản theo mã tài khoản
        public string LaySoTKTheoMa(string ma)
        {
            return gd.LaySoTKTheoMa(ma);
        }

        //hàm thêm tiền vào lại tài khoản khi xóa
        public void ThemTienVaoLaiTK(decimal sotiengd, string sotk)
        {
            gd.ThemTienVaoLaiTK(sotiengd, sotk);
        }

        //gọi hàm trừ tiền trong tài khoản
        public void TruTien(decimal sotiendg, string sotk)
        {
            gd.TruTien(sotiendg, sotk);
        }

        //gọi hàm ThemGiaoDich từ DAL
        public bool ThemGiaoDich(ET_GiaoDich et)
        {
            return gd.ThemGiaoDich(et);
        }

        //gọi hàm SuaGiaoDich từ DAL
        public bool SuaGiaoDich(ET_GiaoDich et)
        {
            return gd.SuaGiaoDich(et);
        }

        //gọi hàm XoaGiaoDich từ DAL
        public bool XoaGiaoDich(ET_GiaoDich et)
        {
            return gd.XoaGiaoDich(et);
        }
    }
}
