using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BUS
{
    public class BUS_PhongBan
    {
        DAL_PhongBan pb = new DAL_PhongBan();

        public IQueryable LoadDSPB()
        {
            return pb.LoadDSPB();
        }

        public IQueryable LoadTenPB()
        {
            return pb.LoadTenPB();
        }

        public IQueryable TimPBTheoMa(int ma)
        {
            return pb.TimPBTheoMa(ma);
        }

        public IQueryable TimPBTheoTen(string ten)
        {
            return pb.TimPBTheoTen(ten);
        }

        public bool ThemPB(ET_PhongBan et)
        {
            return pb.ThemPB(et);
        }

        public bool SuaPB(ET_PhongBan et)
        {
            return pb.SuaPB(et);
        }

        public bool XoaPB(ET_PhongBan et)
        {
            return pb.XoaPB(et);
        }
    }
}
