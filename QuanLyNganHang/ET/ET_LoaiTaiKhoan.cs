using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_LoaiTaiKhoan
    {
        private string _MaLoaiTK;
        private string _ChiTiet;

        public ET_LoaiTaiKhoan(string maLoaiTK, string chiTiet)
        {
            _MaLoaiTK = maLoaiTK;
            _ChiTiet = chiTiet;
        }

        public string MaLoaiTK { get => _MaLoaiTK; set => _MaLoaiTK = value; }
        public string ChiTiet { get => _ChiTiet; set => _ChiTiet = value; }
    }
}
