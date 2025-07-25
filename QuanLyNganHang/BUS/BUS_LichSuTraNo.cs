using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Lấy danh sách khoản vay
        public IQueryable LoadDSKhoanVay()
        {
            return ls.LoadKhoanVay();
        }

        // Thêm lịch sử trả nợ
        public bool ThemLichSuTraNo(ET.ET_LichSuTraNo et,out string error)
        {
            return ls.ThemLichSuTraNo(et, out error);
        }

        // Cập nhật lịch sử trả nợ
        public bool CapNhatLichSuTraNo(ET.ET_LichSuTraNo et, out string error)
        {
            return ls.CapNhatLichSuTraNo(et, out error);
        }

        // Xóa lịch sử trả nợ
        public bool XoaLichSuTraNo(ET.ET_LichSuTraNo et,out string error)
        {
            return ls.XoaLichSuTraNo(et, out error);
        }

        //tìm kiếm lịch sử trả nợ
        public IQueryable TimKiemLichSuTraNo(string maLichSu)
        {
            return ls.TimKiemLSTN(maLichSu);
        }
    }
    public class BUS_LichSuTraNo_RP
    {
        DAL_LichSuTraNo_RP kv = new DAL_LichSuTraNo_RP();

        // Lấy danh sách lịch sử trả nợ để báo cáo
        public List<ET_LichSuTraNo_RP> LoadLSTNRP()
        {
            return kv.LoadDSLSTN();
        }

        //tim kiếm Lich Su Trả Nợ de bao cáo
        public List<ET_LichSuTraNo_RP> TimLSTNRP(string keyword)
        {
            return kv.TimRPLSTN(keyword);
        }
    }
}
