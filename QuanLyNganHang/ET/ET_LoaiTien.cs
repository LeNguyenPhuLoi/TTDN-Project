using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_LoaiTien
    {
        private string _MaLoaiTien;
        private string _TenLoaiTien;
        private string _KyHieu;
        private string _QuocGia;
        private string _TrangThai;

        public ET_LoaiTien(string maLoaiTien, string tenLoaiTien, string kyHieu, string quocGia, string trangThai)
        {
            _MaLoaiTien = maLoaiTien;
            _TenLoaiTien = tenLoaiTien;
            _KyHieu = kyHieu;
            _QuocGia = quocGia;
            _TrangThai = trangThai;
        }

        public string MaLoaiTien { get => _MaLoaiTien; set => _MaLoaiTien = value; }
        public string TenLoaiTien { get => _TenLoaiTien; set => _TenLoaiTien = value; }
        public string KyHieu { get => _KyHieu; set => _KyHieu = value; }
        public string QuocGia { get => _QuocGia; set => _QuocGia = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}
