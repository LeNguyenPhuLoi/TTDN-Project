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
    }
}
