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

        public IQueryable LoadDSVP()
        {
            return vp.LoadDSVP();
        }

        public IQueryable LoadNQ()
        {
            return vp.LoadNQ();
        }

        public IQueryable LoadNV()
        {
            return vp.LoadNV();
        }

        public IQueryable LoadKH()
        {
            return vp.LoadKH();
        }

        public IQueryable LoadMoTa()
        {
            return vp.LoadMoTa();
        }

        public string LayTieuDeNQTheoMa(string ma)
        {
            return vp.LayTieuDeNQTheoMa(ma);
        }

        public string LayTenNVTheoMa(string ma)
        {
            return vp.LayTenNVTheoMa(ma);
        }

        public string LayTenKHTheoMa(string ma)
        {
            return vp.LayTenKHTheoMa(ma);
        }

        public string LayMaNQTheoTieuDe(string ten)
        {
            return vp.LayMaNQTheoTieuDe(ten);
        }

        public string LayMaNVTheoTen(string ten)
        {
            return vp.LayMaNVTheoTen(ten);
        }

        public string LayMaKHTheoTen(string ten)
        {
            return vp.LayMaKHTheoTen(ten);
        }

        public IQueryable TimVPTheoMa(string ma)
        {
            return vp.TimVPTheoMa(ma);
        }

        public IQueryable TimVPTheoNQ(string nq)
        {
            return vp.TimVPTheoNQ(nq);
        }

        public IQueryable TimVPTheoNV(string nv)
        {
            return vp.TimVPTheoNV(nv);
        }

        public IQueryable TimVPTheoKH(string kh)
        {
            return vp.TimVPTheoKH(kh);
        }

        public IQueryable TimVPTheoMoTa(string mota)
        {
            return vp.TimVPTheoMoTa(mota);
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
