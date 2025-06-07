using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    {
        //Kết nối với Linq to SQL
        QLNHDataContext db = new QLNHDataContext();

        //Kiểm tra đăng nhập
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            var user = db.DANGNHAPs.FirstOrDefault(u => u.MADN == tenDangNhap && u.PASS == matKhau);
            return user != null;
        }
    }
}
