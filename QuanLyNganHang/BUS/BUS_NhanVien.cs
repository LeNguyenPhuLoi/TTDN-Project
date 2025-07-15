using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
using static ET.ET_NhanVien;

namespace BUS
{

    public class BUS_ReportNhanVien
    {
        DAL_ReportNhanVien nv = new DAL_ReportNhanVien();

        public List<ET_ReportNhanVien> LoadDSNhanVien()
        {
            return nv.LoadDSNhanVien();
        }

        public List<ET_ReportNhanVien> TimRPNhanVienTheoMa(string ma)
        {
            return nv.TimRPNhanVienTheoMa(ma);
        }

        public List<ET_ReportNhanVien> TimRPNhanVienTheoTen(string ten)
        {
            return nv.TimRPNhanVienTheoTen(ten);
        }

        public List<ET_ReportNhanVien> TimRPNhanVienTheoSdt(string sdt)
        {
            return nv.TimRPNhanVienTheoSdt(sdt);
        }
    }
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();

        public IQueryable LoadDSNV()
        {
            return nv.LoadDSNV();
        }

        public IQueryable LoadTenPB()
        {
            return nv.LoadTenPB();
        }

        public IQueryable LoadTenCN()
        {
            return nv.LoadTenCN();
        }

        public string LayTenPBTheoMa(int ma)
        {
            return nv.LayTenPBTheoMa(ma);
        }

        public string LayTenCNTheoMa(string ma)
        {
            return nv.LayTenCNTheoMa(ma);
        }

        public int LayMaPBTheoTen(string ten)
        {
            return nv.LayMaPBTheoTen(ten);
        }

        public string LayMaCNTheoTen(string ten)
        {
            return nv.LayMaCNTheoTen(ten);
        }

        public IQueryable TimNVTheoMa(string ma)
        {
            return nv.TimNVTheoMa(ma);
        }

        public IQueryable TimNVTheoTen(string ten)
        {
            return nv.TimNVTheoTen(ten);
        }

        public IQueryable TimNVTheoSDT(int sdt)
        {
            return nv.TimNVTheoSDT(sdt);
        }

        public IQueryable TimNVTheoTenCN(string tencn)
        {
            return nv.TimNVTheoTenCN(tencn);
        }

        public bool ThemNV(ET_NhanVien et)
        {
            return nv.ThemNV(et);
        }

        public bool SuaNV(ET_NhanVien et)
        {
            return nv.SuaNV(et);
        }

        public bool XoaNV(ET_NhanVien et)
        {
            return nv.XoaNV(et);
        }
    }
}
