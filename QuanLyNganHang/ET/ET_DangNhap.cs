using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_DangNhap
    {
        public ET_DangNhap(string mADN, string pASS, string qUYEN, string mANV)
        {
            MADN = mADN;
            PASS = pASS;
            QUYEN = qUYEN;
            MANV = mANV;
        }

        public string MADN { get; set; }
        public string PASS { get; set; }
        public string QUYEN { get; set; }
        public string MANV { get; set; }
    }
}
