using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using ET;

namespace DAL
{
    public class DAL_LoaiTaiKhoan
    {
        //kết nối database = linq to sql
        QLNHDataContext db = new QLNHDataContext();

        //hàm lấy danh sách loại tài khoản
        public IQueryable LoadDSLoaiTaiKhoan()
        {
            IQueryable LTK = from ltk in db.LOAITAIKHOANs
                             select ltk;
            return LTK;
        }

        //hàm thêm loại tài khoản
        public bool ThemLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;
            try
            {
                var exist = db.LOAITAIKHOANs.Any(x => x.MALOAITK == et.MaLoaiTK);
                if (!exist) 
                {
                    LOAITAIKHOAN ltk = new LOAITAIKHOAN()
                    {
                        MALOAITK = et.MaLoaiTK,
                        CHITIET = et.ChiTiet
                    };
                    db.LOAITAIKHOANs.InsertOnSubmit(ltk);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex) 
            {
                flag = false;
                Console.WriteLine("Lỗi: "+ex.ToString());
            }
            return flag;
        }

        //hàm sửa thông tin loại tài khoản
        public bool SuaThongTinLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;
            try
            {
                var update = db.LOAITAIKHOANs.SingleOrDefault(x => x.MALOAITK == et.MaLoaiTK);
                if(update != null)
                {
                    update.CHITIET = et.ChiTiet;

                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            return flag;
        }

        //hàm xóa loại tài khoản
        public bool XoaLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;
            try
            {
                var ltk = db.LOAITAIKHOANs.SingleOrDefault(x => x.MALOAITK == et.MaLoaiTK);
                if(ltk != null)
                {
                    db.LOAITAIKHOANs.DeleteOnSubmit(ltk);
                    db.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            return flag;
        }
    }
}
