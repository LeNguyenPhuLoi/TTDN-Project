using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_ChiNhanh
    {
        private string _MaCN;
        private string _TenCN;
        private string _DiaChiCN;
        private int _SdtCN;

        public ET_ChiNhanh(string maCN, string tenCN, string diaChiCN, int sdtCN)
        {
            _MaCN = maCN;
            _TenCN = tenCN;
            _DiaChiCN = diaChiCN;
            _SdtCN = sdtCN;
        }

        public string MaCN { get => _MaCN; set => _MaCN = value; }
        public string TenCN { get => _TenCN; set => _TenCN = value; }
        public string DiaChiCN { get => _DiaChiCN; set => _DiaChiCN = value; }
        public int SdtCN { get => _SdtCN; set => _SdtCN = value; }
    }
}
