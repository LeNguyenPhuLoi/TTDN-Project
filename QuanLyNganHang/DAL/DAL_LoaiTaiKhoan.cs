using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using ET;

namespace DAL
{
    public class DAL_LoaiTaiKhoanRP
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LoaiTaiKhoanRP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách loại tài khoản cho report
        public List<ET_LoaiTaiKhoanRP> LoadDSLoaiTaiKhoan()
        {
            var query = from ltk in db.LOAITAIKHOANs
                        select new ET_LoaiTaiKhoanRP
                        {
                            MaLoaiTK = ltk.MALOAITK,
                            ChiTiet = ltk.CHITIET,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách loại tài khoản cho report theo mã
        public List<ET_LoaiTaiKhoanRP> LoadDSLoaiTaiKhoanTheoMa(string ma)
        {
            var query = from ltk in db.LOAITAIKHOANs
                        where ltk.MALOAITK.Contains(ma)
                        select new ET_LoaiTaiKhoanRP
                        {
                            MaLoaiTK = ltk.MALOAITK,
                            ChiTiet = ltk.CHITIET,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách loại tài khoản cho report theo chi tiết
        public List<ET_LoaiTaiKhoanRP> LoadDSLoaiTaiKhoanTheoChiTiet(string chitiet)
        {
            var query = from ltk in db.LOAITAIKHOANs
                        where ltk.CHITIET.Contains(chitiet)
                        select new ET_LoaiTaiKhoanRP
                        {
                            MaLoaiTK = ltk.MALOAITK,
                            ChiTiet = ltk.CHITIET,
                        };

            return query.ToList();
        }
    }

        public class DAL_LoaiTaiKhoan
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LoaiTaiKhoan()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách loại tài khoản
        public IQueryable LoadDSLoaiTaiKhoan()
        {
            IQueryable LTK = from ltk in db.LOAITAIKHOANs
                             select ltk;
            return LTK;
        }

        //hàm tìm loại tài khoản theo mã
        public IQueryable LayLTKTheoMa(string ma)
        {
            IQueryable LTK = from ltk in db.LOAITAIKHOANs
                             where ltk.MALOAITK.Contains(ma)
                             select ltk;
            return LTK;
        }

        //hàm tìm loại tài khoản theo chi tiết
        public IQueryable LayLTKTheoChiTiet(string chitiet)
        {
            IQueryable LTK = from ltk in db.LOAITAIKHOANs
                             where ltk.CHITIET.Contains(chitiet)
                             select ltk;
            return LTK;
        }

        //hàm thêm loại tài khoản
        public bool ThemLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
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
            db = new QLNHDataContext(conn.GetConnection());
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
            db = new QLNHDataContext(conn.GetConnection());
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
