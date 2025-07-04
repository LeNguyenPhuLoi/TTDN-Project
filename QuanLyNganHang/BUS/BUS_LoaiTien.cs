﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiTien
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_LoaiTien lt = new DAL_LoaiTien();

        //gọi hàm LayDSLoaiTien từ DAL
        public IQueryable LayDSLoaiTien()
        {
            return lt.LayDSLoaiTien();
        }

        //hàm tìm loại tiền theo mã
        public IQueryable TimLoaiTienTheoMa(string ma)
        {
            return lt.TimLoaiTienTheoMa(ma);
        }

        //hàm tìm loại tiền theo tên
        public IQueryable TimLoaiTienTheoTen(string ten)
        {
            return lt.TimLoaiTienTheoTen(ten);
        }

        //hàm tìm loại tiền theo quốc gia
        public IQueryable TimLoaiTienTheoQG(string qg)
        {
            return lt.TimLoaiTienTheoQG(qg);
        }

        //gọi hàm ThemLoaiTien từ DAL
        public bool ThemLoaiTien(ET_LoaiTien et)
        {
            return lt.ThemLoaiTien(et);
        }

        //gọi hàm SuaThongTinLoaiTien từ DAL
        public bool SuaThongTinLoaiTien(ET_LoaiTien et)
        {
            return lt.SuaThongTinLoaiTien(et);
        }

        //gọi hàm XoaLoaiTien từ DAL
        public bool XoaLoaiTien(ET_LoaiTien et)
        {
            return lt.XoaLoaiTien(et);
        }
    }
}
