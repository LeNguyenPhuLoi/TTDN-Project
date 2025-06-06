using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_KhuyenMai
    {
        public ET_KhuyenMai(string mAKM, string tENKM, string mOTA, DateTime nGAYBD, DateTime nGAYKT, string dKAPDUNG)
        {
            MAKM = mAKM;
            TENKM = tENKM;
            MOTA = mOTA;
            NGAYBD = nGAYBD;
            NGAYKT = nGAYKT;
            DKAPDUNG = dKAPDUNG;
        }

        public string MAKM { get; set; } // Mã khuyến mãi
        public string TENKM { get; set; } // Tên khuyến mãi
        public string MOTA { get; set; } // Mô tả khuyến mãi
        public DateTime NGAYBD { get; set; } // Ngày bắt đầu 
        public DateTime NGAYKT { get; set; } // Ngày kết thúc
        public string DKAPDUNG { get; set; } // Điều kiện áp dụng
    }
}
