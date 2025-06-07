using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private string _GioiTinh;
        private string _Cccd;
        private string _Sdt;
        private string _Email;
        private string _DiaChi;
        private string _QuocTich;
        private string _DoiTuong;
        private DateTime _NgayTao;

        public ET_KhachHang(string maKH, string tenKH, string gioiTinh, string cccd, string sdt, string email, string diaChi, string quocTich, string doiTuong, DateTime ngayTao)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _GioiTinh = gioiTinh;
            _Cccd = cccd;
            _Sdt = sdt;
            _Email = email;
            _DiaChi = diaChi;
            _QuocTich = quocTich;
            _DoiTuong = doiTuong;
            _NgayTao = ngayTao;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string Cccd { get => _Cccd; set => _Cccd = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string QuocTich { get => _QuocTich; set => _QuocTich = value; }
        public string DoiTuong { get => _DoiTuong; set => _DoiTuong = value; }
        public DateTime NgayTao { get => _NgayTao; set => _NgayTao = value; }
    }
}
