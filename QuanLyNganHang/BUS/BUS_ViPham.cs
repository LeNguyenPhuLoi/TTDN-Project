using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BUS
{
    public class BUS_ViPham
    {
        DAL_ViPham vp = new DAL_ViPham();

        public IQueryable LoadDSVP(ET_ViPham et)
        {
            return vp.LoadDSVP();
        }

        public bool ThemVP(ET_ViPham et)
        {
            return vp.ThemVP(et);
        }

        public bool SuaVP(ET_ViPham et)
        {
            return vp.SuaVP(et);
        }

        public bool XoaVP(ET_ViPham et)
        {
            return vp.XoaVP(et);
        }
    }
}
