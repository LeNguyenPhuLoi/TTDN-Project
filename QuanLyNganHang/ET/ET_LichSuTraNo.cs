using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_LichSuTraNo
    {
        public ET_LichSuTraNo(string mALICHSU, string mAVAY,decimal tIENGOC, decimal sOTIENTRA, DateTime nGAYTRA)
        {
            MALICHSU = mALICHSU;
            MAVAY = mAVAY;
            TIENGOC = tIENGOC;
            SOTIENTRA = sOTIENTRA;
            NGAYTRA = nGAYTRA;
        }

        public string MALICHSU { get; set; }
        public string MAVAY { get; set; }
        public decimal TIENGOC { get; set; }
        public decimal SOTIENTRA { get; set; }
        public DateTime NGAYTRA { get; set; }
    }
}
