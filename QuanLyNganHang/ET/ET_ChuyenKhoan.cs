using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_ChuyenKhoan
    {

        public string MACK { get; set; }
        public DateTime NGAYCK { get; set; }
        public decimal SOTIEN { get; set; }
        public string MATKGUI { get; set; }
        public string MATKNHAN { get; set; }
        public string NOIDUNG { get; set; }
        public ET_ChuyenKhoan(string mACK, DateTime nGAYCK, decimal sOTIEN, string mATKGUI, string mATKNHAN, string nOIDUNG)
        {
            MACK = mACK;
            NGAYCK = nGAYCK;
            SOTIEN = sOTIEN;
            MATKGUI = mATKGUI;
            MATKNHAN = mATKNHAN;
            NOIDUNG = nOIDUNG;
        }
    }
}
