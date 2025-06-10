using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_BienLai
    {
        //tạo đối tượng xử lý nghiệp vụ
        DAL_BienLai bl = new DAL_BienLai();

        //gọi hàm LayDSBienLai từ DAL
        public IQueryable LayDSBienLai()
        {
            return bl.LayDSBienLai();
        }

        //gọi hàm ThemBienLai từ DAL
        public bool ThemBienLai(ET_BienLai et)
        {
            return bl.ThemBienLai(et);
        }

        //gọi hàm SuaBienLai từ DAL
        public bool SuaBienLai(ET_BienLai et)
        {
            return bl.SuaBienLai(et);
        }

        //gọi hàm XoaBienLai từ DAL
        public bool XoaBienLai(ET_BienLai et)
        {
            return bl.XoaBienLai(et);
        }
    }
}
