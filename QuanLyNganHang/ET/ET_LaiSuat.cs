using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_LaiSuat
    {
        public ET_LaiSuat(string mALAISUAT, string tENLAISUAT, int lAISUAT,string KIEUlai)
        {
            MALAISUAT = mALAISUAT;
            TENLAISUAT = tENLAISUAT;
            LAISUAT = lAISUAT;
            KIEULAI = KIEUlai;
        }

        public string MALAISUAT { get; set; }
        public string TENLAISUAT { get; set; }
        public int LAISUAT { get; set; }
        public string KIEULAI { get; set; }

    }
}
