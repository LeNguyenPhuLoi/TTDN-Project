using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_KhoanVay
    {
        public ET_KhoanVay(string mAVAY, decimal sOTIENVAY, decimal sOTIENLAI,decimal tIENTHANG, DateTime nGAYVAY, DateTime tHOIHAN,int sOTHANG, string tRANGTHAI, string mAKH, string mALAISUAT)
        {
            MAVAY = mAVAY;
            SOTIENVAY = sOTIENVAY;
            TONGTIEN = sOTIENLAI;
            TIENTHANG = tIENTHANG;
            NGAYVAY = nGAYVAY;
            THOIHAN = tHOIHAN;
            SOTHANG = sOTHANG;
            TRANGTHAI = tRANGTHAI;
            MAKH = mAKH;
            MALAISUAT = mALAISUAT;
        }

        public string MAVAY { get; set; }
        public decimal SOTIENVAY { get; set; }
        public decimal TONGTIEN { get; set; }
        public decimal TIENTHANG { get; set; }
        public DateTime NGAYVAY { get; set; }
        public DateTime THOIHAN { get; set; }
        public int SOTHANG { get; set; }
        public string TRANGTHAI { get; set; }
        public string MAKH { get; set; }
        public string MALAISUAT { get; set; }
    }
}
