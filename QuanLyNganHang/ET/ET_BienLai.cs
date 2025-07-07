using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_BienLai
    {
        private string _MaBL;
        private string _MaGD;
        private string _MaKH;
        private string _MaTK;
        private string _MaNV;
        private decimal _SoTien;
        private string _MaLoaiTien;
        private string _LoaiBL;
        private string _Mota;
        private string _TrangThai;

        public ET_BienLai(string maBL, string maGD, string maKH, string maTK, string maNV, decimal soTien, string maLoaiTien, string loaiBL, string mota, string trangThai)
        {
            _MaBL = maBL;
            _MaGD = maGD;
            _MaKH = maKH;
            _MaTK = maTK;
            _MaNV = maNV;
            _SoTien = soTien;
            _MaLoaiTien = maLoaiTien;
            _LoaiBL = loaiBL;
            _Mota = mota;
            _TrangThai = trangThai;
        }

        public string MaBL { get => _MaBL; set => _MaBL = value; }
        public string MaGD { get => _MaGD; set => _MaGD = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaTK { get => _MaTK; set => _MaTK = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public decimal SoTien { get => _SoTien; set => _SoTien = value; }
        public string MaLoaiTien { get => _MaLoaiTien; set => _MaLoaiTien = value; }
        public string LoaiBL { get => _LoaiBL; set => _LoaiBL = value; }
        public string Mota { get => _Mota; set => _Mota = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }

    public class ET_BienLaiRP
    {
        public string MaBL { get; set; }
        public string MaGD { get; set; }
        public string TenKH { get; set; }
        public string SoTaiKhoan { get; set; }
        public string TenNV { get; set; }
        public decimal SoTien { get; set; }
        public string TenLoaiTien { get; set; }
        public string LoaiBL { get; set; }
        public string Mota { get; set; }
        public string TrangThai { get; set; }
    }
}
