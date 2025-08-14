using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using static ET.ET_NhanVien;

namespace DAL
{
    public class DAL_ReportNhanVien
    {
        //kết nối database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ReportNhanVien()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public List<ET_ReportNhanVien> LoadDSNhanVien()
        {
            var fast = from nv in db.NHANVIENs
                        select new ET_ReportNhanVien
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = Convert.ToDateTime(nv.NGAYSINH),
                            Chuc = nv.CHUC,
                            Luong = Convert.ToInt32(nv.LUONG),
                            DiaChi = nv.DIACHI,
                            Sdt = Convert.ToInt32(nv.SDT),
                            MaCN = nv.MACN,
                            MaPB = Convert.ToInt32(nv.MAPB),

                        };

            return fast.ToList();
        }

        public List<ET_ReportNhanVien> TimRPNhanVienTheoMa(string ma)
        {
            var fast = from nv in db.NHANVIENs
                        where nv.MANV.Contains(ma)
                        select new ET_ReportNhanVien
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = Convert.ToDateTime(nv.NGAYSINH),
                            Chuc = nv.CHUC,
                            Luong = Convert.ToInt32(nv.LUONG),
                            DiaChi = nv.DIACHI,
                            Sdt = Convert.ToInt32(nv.SDT),
                            MaCN = nv.MACN,
                            MaPB = Convert.ToInt32(nv.MAPB),
                        };

            return fast.ToList();
        }

        public List<ET_ReportNhanVien> TimRPNhanVienTheoTen(string ten)
        {
            var fast = from nv in db.NHANVIENs
                        where nv.TENNV.Contains(ten)
                        select new ET_ReportNhanVien
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = Convert.ToDateTime(nv.NGAYSINH),
                            Chuc = nv.CHUC,
                            Luong = Convert.ToInt32(nv.LUONG),
                            DiaChi = nv.DIACHI,
                            Sdt = Convert.ToInt32(nv.SDT),
                            MaCN = nv.MACN,
                            MaPB = Convert.ToInt32(nv.MAPB),
                        };

            return fast.ToList();
        }

        public List<ET_ReportNhanVien> TimRPNhanVienTheoSdt(string sdt)
        {
            var fast = from nv in db.NHANVIENs
                        where nv.SDT.ToString().Contains(sdt)
                        select new ET_ReportNhanVien
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioiTinh = nv.GIOITINH,
                            NgaySinh = Convert.ToDateTime(nv.NGAYSINH),
                            Chuc = nv.CHUC,
                            Luong = Convert.ToInt32(nv.LUONG),
                            DiaChi = nv.DIACHI,
                            Sdt = Convert.ToInt32(nv.SDT),
                            MaCN = nv.MACN,
                            MaPB = Convert.ToInt32(nv.MAPB),
                        };

            return fast.ToList();
        }
    }

    public class DAL_NhanVien
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_NhanVien()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lấy ds nhân viên
        public IQueryable LoadDSNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select new {nv.MANV, nv.TENNV, nv.GIOITINH, nv.NGAYSINH, nv.CHUC, nv.LUONG, nv.DIACHI, nv.SDT, nv.MAPB, nv.MACN};
            return NV;
        }

        public IQueryable LoadTenPB()
        {
            IQueryable PB = from pb in db.PHONGBANs
                            select pb.TENPB;
            return PB;
        }

        public IQueryable LoadTenCN()
        {
            IQueryable CN = from cn in db.CHINHANHs
                            select cn.TENCN;
            return CN;
        }

        public string LayTenPBTheoMa(int ma)
        {
            string ten = (from pb in db.PHONGBANs
                          where pb.MAPB == ma
                          select pb.TENPB).FirstOrDefault();
            return ten;
        }

        public string LayTenCNTheoMa(string ma)
        {
            string ten = (from cn in db.CHINHANHs
                          where cn.MACN == ma
                          select cn.TENCN).FirstOrDefault();
            return ten;
        }

        public int LayMaPBTheoTen(string ten)
        {
            int ma = (from pb in db.PHONGBANs
                      where pb.TENPB == ten
                      select pb.MAPB).FirstOrDefault();
            return ma;
        }

        public string LayMaCNTheoTen(string ten)
        {
            string ma = (from cn in db.CHINHANHs
                         where cn.TENCN == ten
                         select cn.MACN).FirstOrDefault();
            return ma;
        }

        public IQueryable TimNVTheoMa(string ma)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.MANV.Contains(ma)
                            select new { nv.MANV, nv.TENNV, nv.GIOITINH, nv.NGAYSINH, nv.CHUC, nv.LUONG, nv.DIACHI, nv.SDT, nv.MAPB, nv.MACN };
            return NV;
        }

        public IQueryable TimNVTheoTen(string ten)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.TENNV.Contains(ten)
                            select new { nv.MANV, nv.TENNV, nv.GIOITINH, nv.NGAYSINH, nv.CHUC, nv.LUONG, nv.DIACHI, nv.SDT, nv.MAPB, nv.MACN };
            return NV;
        }

        public IQueryable TimNVTheoSDT(int sdt)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.SDT == sdt
                            select new { nv.MANV, nv.TENNV, nv.GIOITINH, nv.NGAYSINH, nv.CHUC, nv.LUONG, nv.DIACHI, nv.SDT, nv.MAPB, nv.MACN };
            return NV;
        }

        public IQueryable TimNVTheoTenCN(string tencn)
        {
            IQueryable NV = from nv in db.NHANVIENs
                            where nv.MACN.Contains(LayMaCNTheoTen(tencn))
                            select new { nv.MANV, nv.TENNV, nv.GIOITINH, nv.NGAYSINH, nv.CHUC, nv.LUONG, nv.DIACHI, nv.SDT, nv.MAPB, nv.MACN };

            return NV;
        }
        //Thêm nhân viên
        public bool ThemNV(ET_NhanVien et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var amp = db.NHANVIENs.Any(nv => nv.MANV == et.MaNV);
                if (!amp)
                {
                    NHANVIEN nv = new NHANVIEN
                    {
                        MANV = et.MaNV,
                        TENNV = et.TenNV,
                        GIOITINH = et.GioiTinh,
                        NGAYSINH = et.NgaySinh,
                        CHUC = et.Chuc,
                        LUONG = et.Luong,
                        DIACHI = et.DiaChi,
                        SDT = et.Sdt,
                        MAPB = et.MaPB,
                        MACN = et.MaCN
                    };
                    db.NHANVIENs.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Sửa nhân viên
        public bool SuaNV(ET_NhanVien et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.NHANVIENs.SingleOrDefault(nv => nv.MANV == et.MaNV);
                if (change != null)
                {
                    change.MANV = et.MaNV;
                    change.TENNV = et.TenNV;
                    change.GIOITINH = et.GioiTinh;
                    change.NGAYSINH = et.NgaySinh;
                    change.CHUC = et.Chuc;
                    change.LUONG = et.Luong;
                    change.DIACHI = et.DiaChi;
                    change.SDT = et.Sdt;
                    change.MAPB = et.MaPB;
                    change.MACN = et.MaCN;

                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Xóa nhân viên
        public bool XoaNV(ET_NhanVien et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var delete = db.NHANVIENs.SingleOrDefault(nv => nv.MANV == et.MaNV);
                if(delete != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }
    }
}
