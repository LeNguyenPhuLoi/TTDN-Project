using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BUS
{
    public class BUS_ChiNhanh
    {
        DAL_ChiNhanh cn = new DAL_ChiNhanh();

        public IQueryable LoadDSCN()
        {
            return cn.LoadDSCN();
        }

        public IQueryable TimCNTheoMa(string ma)
        {
            return cn.TimCNTheoMa(ma);
        }

        public IQueryable TimCNTheoTen(string ten)
        {
            return cn.TimCNTheoTen(ten);
        }

        public IQueryable TimCNTheoSDT(int sdt)
        {
            return cn.TimCNTheoSDT(sdt);
        }

        public bool ThemCN(ET_ChiNhanh et)
        {
            return cn.ThemCN(et);
        }

        public bool SuaCN(ET_ChiNhanh et)
        {
            return cn.SuaCN(et);
        }

        public bool XoaCN(ET_ChiNhanh et)
        {
            return cn.XoaCN(et);
        }
    }
}
