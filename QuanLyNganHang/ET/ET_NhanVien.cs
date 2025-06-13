using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_NhanVien
    {
        private string _MaNV;
        private string _TenNV;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _Chuc;
        private float _Luong;
        private string _DiaChi;
        private int _Sdt;
        private int _MaPB;
        private string _MaCN;

        public ET_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string chuc, float luong, string diaChi, int sdt, int maPB, string maCN)
        {
            _MaNV = maNV;
            _TenNV = tenNV;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _Chuc = chuc;
            _Luong = luong;
            _DiaChi = diaChi;
            _Sdt = sdt;
            _MaPB = maPB;
            _MaCN = maCN;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string Chuc { get => _Chuc; set => _Chuc = value; }
        public float Luong { get => _Luong; set => _Luong = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public int Sdt { get => _Sdt; set => _Sdt = value; }
        public int MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaCN { get => _MaCN; set => _MaCN = value; }
    }
}
