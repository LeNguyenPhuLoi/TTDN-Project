﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();

        public IQueryable LoadDSNV()
        {
            return nv.LoadDSNV();
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
