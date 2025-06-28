using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_KhoanVay
    {
        public ET_KhoanVay(string mAVAY, decimal sOTIENVAY, decimal sOTIENLAI, DateTime nGAYVAY, DateTime tHOIHAN, string tRANGTHAI, string mAKH, string mALAISUAT)
        {
            MAVAY = mAVAY;
            SOTIENVAY = sOTIENVAY;
            SOTIENLAI = sOTIENLAI;
            NGAYVAY = nGAYVAY;
            THOIHAN = tHOIHAN;
            TRANGTHAI = tRANGTHAI;
            MAKH = mAKH;
            MALAISUAT = mALAISUAT;
        }

        public string MAVAY { get; set; }
        public decimal SOTIENVAY { get; set; }
        public decimal SOTIENLAI { get; set; }
        public DateTime NGAYVAY { get; set; }
        public DateTime THOIHAN { get; set; }
        public string TRANGTHAI { get; set; }
        public string MAKH { get; set; }
        public string MALAISUAT { get; set; }
    }
}
