using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLop
{
    internal class HocSinh
    {
        private string _TenHS;
        private string _HoHS;
        private string _GioiTinh;
        private int _MaHS;
        private int _MaLop;
        private DateTime _NgaySinh;

        public HocSinh() { }

        public HocSinh(string tenHS)
        {
            _TenHS = tenHS;
        }

        public HocSinh(string tenHS, string hoHS)
        {
            _TenHS = tenHS;
            _HoHS = hoHS;
        }

        public HocSinh(string tenHS, string hoHS, string gioiTinh)
        {
            _TenHS = tenHS;
            _HoHS = hoHS;
            _GioiTinh = gioiTinh;
        }

        public HocSinh(string tenHS, string hoHS, string gioiTinh, int maHS)
        {
            _TenHS = tenHS;
            _HoHS = hoHS;
            _GioiTinh = gioiTinh;
            _MaHS = maHS;
        }

        public HocSinh(string tenHS, string hoHS, string gioiTinh, int maHS, int maLop)
        {
            _TenHS = tenHS;
            _HoHS = hoHS;
            _GioiTinh = gioiTinh;
            _MaHS = maHS;
            _MaLop = maLop;
        }

        public HocSinh(string tenHS, string hoHS, string gioiTinh, int maHS, int maLop, DateTime ngaySinh)
        {
            _TenHS = tenHS;
            _HoHS = hoHS;
            _GioiTinh = gioiTinh;
            _MaHS = maHS;
            _MaLop = maLop;
            _NgaySinh = ngaySinh;
        }

        public int MaLop { get => _MaLop; set => _MaLop = value; } 
        public string HoHS { get => _HoHS; set => _HoHS = value; }
        public string TenHS { get => _TenHS; set => _TenHS = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public int MaHS { get => _MaHS; set => _MaHS = value; }

    }
}
