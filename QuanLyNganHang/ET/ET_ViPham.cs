using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_ViPham
    {
        private string _MaVP;
        private string _MaNQ;
        private string _MaNV;
        private string _MaKH;
        private DateTime _NgayVP;
        private string _MoTaVP;
        private string _HinhThucXL;
        private string _TrangThaiXL;

        public ET_ViPham(string maVP, string maNQ, string maNV, string maKH, DateTime ngayVP, string moTaVP, string hinhThucXL, string trangThaiXL)
        {
            _MaVP = maVP;
            _MaNQ = maNQ;
            _MaNV = maNV;
            _MaKH = maKH;
            _NgayVP = ngayVP;
            _MoTaVP = moTaVP;
            _HinhThucXL = hinhThucXL;
            _TrangThaiXL = trangThaiXL;
        }

        public string MaVP { get => _MaVP; set => _MaVP = value; }
        public string MaNQ { get => _MaNQ; set => _MaNQ = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public DateTime NgayVP { get => _NgayVP; set => _NgayVP = value; }
        public string MoTaVP { get => _MoTaVP; set => _MoTaVP = value; }
        public string HinhThucXL { get => _HinhThucXL; set => _HinhThucXL = value; }
        public string TrangThaiXL { get => _TrangThaiXL; set => _TrangThaiXL = value; }

        public class ET_ReportViPham
        {
            public string MaVP { get; set; }
            public string MaNQ { get; set; }
            public string MaNV { get; set; }
            public string MaKH { get; set; }
            public DateTime NgayVP { get; set; }
            public string MoTaVP { get; set; }
            public string HinhThucXL { get; set; }
            public string TrangThaiXL { get; set; }
        }
    }
}
