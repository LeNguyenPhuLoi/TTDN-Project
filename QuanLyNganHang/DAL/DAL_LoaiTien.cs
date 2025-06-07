using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_LoaiTien
    {
        //kết nối database = linq to sql
        QLNHDataContext db = new QLNHDataContext();

        //hàm lấy danh sách loại tiền
        public IQueryable LayDSLoaiTien()
        {
            IQueryable LT = from lt in db.LOAITIENs
                            select lt;
            return LT;
        }

        //hàm thêm loại tiền
        public bool ThemLoaiTien(ET_LoaiTien et)
        {
            bool flag = false;
            try
            {
                var exist = db.LOAITIENs.Any(x => x.MALOAITIEN == et.MaLoaiTien);
                if (!exist) 
                {
                    LOAITIEN lt = new LOAITIEN()
                    {
                        MALOAITIEN = et.MaLoaiTien,
                        TENLOAITIEN = et.TenLoaiTien,
                        KYHIEU = et.KyHieu,
                        QUOCGIA = et.QuocGia,
                        TRANGTHAI = et.TrangThai
                    };
                    db.LOAITIENs.InsertOnSubmit(lt);
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

        //hàm sửa thông tin loại tiền
        public bool SuaThongTinLoaiTien(ET_LoaiTien et)
        {
            bool flag = false;
            try
            {
                var update = db.LOAITIENs.SingleOrDefault(x => x.MALOAITIEN == et.MaLoaiTien);
                if (update != null) 
                {
                    update.TENLOAITIEN = et.TenLoaiTien;
                    update.KYHIEU = et.KyHieu;
                    update.QUOCGIA = et.QuocGia;
                    update.TRANGTHAI = et.TrangThai;

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

        //hàm xóa loại tiền
        public bool XoaLoaiTien(ET_LoaiTien et)
        {
            bool flag = false;
            try
            {
                var lt = db.LOAITIENs.SingleOrDefault(x => x.MALOAITIEN == et.MaLoaiTien);
                if(lt != null)
                {
                    db.LOAITIENs.DeleteOnSubmit(lt);
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
