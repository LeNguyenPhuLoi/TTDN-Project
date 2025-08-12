using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_PhongBan
    {
        private int _MaPB;
        private string _TenPB;

        public ET_PhongBan(int maPB, string tenPB)
        {
            _MaPB = maPB;
            _TenPB = tenPB;
        }

        public int MaPB { get => _MaPB; set => _MaPB = value; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }

        public class ET_ReportPhongBan
        {
            public int MaPB { get; set; }
            public string TenPB { get; set; }

            public string TenNV { get; set; }

            public string MaNV { get; set; }

            public int Sdt { get; set; } 

        }
    }
}
