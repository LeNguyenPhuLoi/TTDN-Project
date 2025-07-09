using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;

namespace DAL
{
    public class DAL_LoaiTienRP
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LoaiTienRP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách loại tiền cho report
        public List<ET_LoaiTienRP> LoadDSLoaiTien()
        {
            var query = from lt in db.LOAITIENs
                        select new ET_LoaiTienRP 
                        { 
                            MaLoaiTien = lt.MALOAITIEN,
                            TenLoaiTien = lt.TENLOAITIEN,
                            KyHieu = lt.KYHIEU,
                            QuocGia = lt.QUOCGIA,
                            TrangThai = lt.TRANGTHAI,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách loại tiền cho report theo mã
        public List<ET_LoaiTienRP> LoadDSLoaiTienTheoMa(string ma)
        {
            var query = from lt in db.LOAITIENs
                        where lt.MALOAITIEN.Contains(ma)
                        select new ET_LoaiTienRP
                        {
                            MaLoaiTien = lt.MALOAITIEN,
                            TenLoaiTien = lt.TENLOAITIEN,
                            KyHieu = lt.KYHIEU,
                            QuocGia = lt.QUOCGIA,
                            TrangThai = lt.TRANGTHAI,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách loại tiền cho report theo tên
        public List<ET_LoaiTienRP> LoadDSLoaiTienTheoTen(string ten)
        {
            var query = from lt in db.LOAITIENs
                        where lt.TENLOAITIEN.Contains(ten)
                        select new ET_LoaiTienRP
                        {
                            MaLoaiTien = lt.MALOAITIEN,
                            TenLoaiTien = lt.TENLOAITIEN,
                            KyHieu = lt.KYHIEU,
                            QuocGia = lt.QUOCGIA,
                            TrangThai = lt.TRANGTHAI,
                        };

            return query.ToList();
        }

        //hàm lấy danh sách loại tiền cho report theo quốc gia
        public List<ET_LoaiTienRP> LoadDSLoaiTienTheoQG(string qg)
        {
            var query = from lt in db.LOAITIENs
                        where lt.QUOCGIA.Contains(qg)
                        select new ET_LoaiTienRP
                        {
                            MaLoaiTien = lt.MALOAITIEN,
                            TenLoaiTien = lt.TENLOAITIEN,
                            KyHieu = lt.KYHIEU,
                            QuocGia = lt.QUOCGIA,
                            TrangThai = lt.TRANGTHAI,
                        };

            return query.ToList();
        }
    }

        public class DAL_LoaiTien
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LoaiTien()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //hàm lấy danh sách loại tiền
        public IQueryable LayDSLoaiTien()
        {
            IQueryable LT = from lt in db.LOAITIENs
                            select lt;
            return LT;
        }

        //hàm tìm loại tiền theo mã
        public IQueryable TimLoaiTienTheoMa(string ma)
        {
            IQueryable LT = from lt in db.LOAITIENs
                            where lt.MALOAITIEN.Contains(ma)
                            select lt;
            return LT;
        }

        //hàm tìm loại tiền theo tên
        public IQueryable TimLoaiTienTheoTen(string ten)
        {
            IQueryable LT = from lt in db.LOAITIENs
                            where lt.TENLOAITIEN.Contains(ten)
                            select lt;
            return LT;
        }

        //hàm tìm loại tiền theo quốc gia
        public IQueryable TimLoaiTienTheoQG(string qg)
        {
            IQueryable LT = from lt in db.LOAITIENs
                            where lt.QUOCGIA.Contains(qg)
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
