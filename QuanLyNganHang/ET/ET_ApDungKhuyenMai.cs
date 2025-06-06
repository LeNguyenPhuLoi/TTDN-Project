using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_ApDungKhuyenMai
    {
        public ET_ApDungKhuyenMai(string mAKM, string mAKH, string mATK, DateTime nGAYAPDUNG)
        {
            MAKM = mAKM;
            MAKH = mAKH;
            MATK = mATK;
            NGAYAPDUNG = nGAYAPDUNG;
        }

        public string MAKM { get; set; } // Mã khuyến mãi
        public string MAKH { get; set; } // Mã khách hàng
        public string MATK { get; set; } // Mã tài khoản 
        public DateTime NGAYAPDUNG { get; set; } // Ngày áp dụng
    }
}
