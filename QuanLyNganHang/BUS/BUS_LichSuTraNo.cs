using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_LichSuTraNo
    {
        DAL_LichSuTraNo ls = new DAL.DAL_LichSuTraNo();

        // Lấy danh sách lịch sử trả nợ
        public IQueryable LoadDSLichSuTraNo()
        {
            return ls.LoadLichSuTraNo();
        }

        // Thêm lịch sử trả nợ
        public bool ThemLichSuTraNo(ET.ET_LichSuTraNo et)
        {
            return ls.ThemLichSuTraNo(et);
        }

        // Cập nhật lịch sử trả nợ
        public bool CapNhatLichSuTraNo(ET.ET_LichSuTraNo et)
        {
            return ls.CapNhatLichSuTraNo(et);
        }

        // Xóa lịch sử trả nợ
        public bool XoaLichSuTraNo(ET.ET_LichSuTraNo et)
        {
            return ls.XoaLichSuTraNo(et);
        }
    }
}
