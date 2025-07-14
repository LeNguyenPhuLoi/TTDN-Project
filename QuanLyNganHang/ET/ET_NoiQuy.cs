using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_NoiQuy
    {
        private string _MaNQ;
        private string _TieuDe;
        private string _MoTa;
        private DateTime _NgayBH;
        private string _LoaiApDung;

        public ET_NoiQuy(string maNQ, string tieuDe, string moTa, DateTime ngayBH, string loaiApDung)
        {
            _MaNQ = maNQ;
            _TieuDe = tieuDe;
            _MoTa = moTa;
            _NgayBH = ngayBH;
            _LoaiApDung = loaiApDung;
        }

        public string MaNQ { get => _MaNQ; set => _MaNQ = value; }
        public string TieuDe { get => _TieuDe; set => _TieuDe = value; }
        public string MoTa { get => _MoTa; set => _MoTa = value; }
        public DateTime NgayBH { get => _NgayBH; set => _NgayBH = value; }
        public string LoaiApDung { get => _LoaiApDung; set => _LoaiApDung = value; }

        public class ET_ReportNoiQuy
        {
            public string MaNQ { get; set; }
            public string TieuDe { get; set; }
            public string MoTa { get; set; }
            public DateTime NgayBH { get; set; }
            public string LoaiApDung { get; set; }
        }
    }
}
