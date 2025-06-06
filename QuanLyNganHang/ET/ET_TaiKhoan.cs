using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_TaiKhoan
    {
        private string _MaTK;
        private string _MaKH;
        private string _SoTaiKhoan;
        private string _MaLoaiTK;
        private decimal _SoDu;
        private string _MaLoaiTien;
        private DateTime _NgayMoTK;
        private string _TrangThai;

        public ET_TaiKhoan(string maTK, string maKH, string soTaiKhoan, string maLoaiTK, decimal soDu, string maLoaiTien, DateTime ngayMoTK, string trangThai)
        {
            _MaTK = maTK;
            _MaKH = maKH;
            _SoTaiKhoan = soTaiKhoan;
            _MaLoaiTK = maLoaiTK;
            _SoDu = soDu;
            _MaLoaiTien = maLoaiTien;
            _NgayMoTK = ngayMoTK;
            _TrangThai = trangThai;
        }

        public string MaTK { get => _MaTK; set => _MaTK = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string SoTaiKhoan { get => _SoTaiKhoan; set => _SoTaiKhoan = value; }
        public string MaLoaiTK { get => _MaLoaiTK; set => _MaLoaiTK = value; }
        public decimal SoDu { get => _SoDu; set => _SoDu = value; }
        public string MaLoaiTien { get => _MaLoaiTien; set => _MaLoaiTien = value; }
        public DateTime NgayMoTK { get => _NgayMoTK; set => _NgayMoTK = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}
