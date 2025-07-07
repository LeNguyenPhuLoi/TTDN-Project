using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_GiaoDich
    {
        private string _MaGD;
        private string _MaTK;
        private string _LoaiGD;
        private decimal _SoTien;
        private DateTime _ThoiGianGD;
        private string _MoTa;
        private string _TrangThai;

        public ET_GiaoDich(string maGD, string maTK, string loaiGD, decimal soTien, DateTime thoiGianGD, string moTa, string trangThai)
        {
            _MaGD = maGD;
            _MaTK = maTK;
            _LoaiGD = loaiGD;
            _SoTien = soTien;
            _ThoiGianGD = thoiGianGD;
            _MoTa = moTa;
            _TrangThai = trangThai;
        }

        public string MaGD { get => _MaGD; set => _MaGD = value; }
        public string MaTK { get => _MaTK; set => _MaTK = value; }
        public string LoaiGD { get => _LoaiGD; set => _LoaiGD = value; }
        public decimal SoTien { get => _SoTien; set => _SoTien = value; }
        public DateTime ThoiGianGD { get => _ThoiGianGD; set => _ThoiGianGD = value; }
        public string MoTa { get => _MoTa; set => _MoTa = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }

    public class ET_GiaoDichRP
    {
        public string MaGD { get; set; }
        public string TenKH { get; set; }
        public string LoaiGD { get; set; }
        public decimal SoTien { get; set; }
        public DateTime ThoiGianGD { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
    }
}
