using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLop
{
    internal class Lop
    {
        private int _MaLop; 
        private string _TenLop;
        private string _TenGV;
        private int _SoLHocSinh;

        public Lop() { }

        public Lop(int maLop)
        {
            _MaLop = maLop;
        }
        public Lop(int maLop, string tenLop)
        {
            _MaLop = maLop;
            _TenLop = tenLop;
        }
        public Lop(int maLop, string tenLop, string tenGV)
        {
            _MaLop = maLop;
            _TenLop = tenLop;
            _TenGV = tenGV;
        }
        public Lop(int maLop, string tenLop, string tenGV, int soLuongHS)
        {
            _MaLop = maLop;
            _TenLop = tenLop;
            _TenGV = tenGV;
            _SoLHocSinh = soLuongHS;
        }


        public int MaLop { get => _MaLop; set => _MaLop = value; }
        public string TenGV { get => _TenGV; set => _TenGV= value; }
        public string TenLop { get => _TenLop ; set => _TenLop = value; }
        public int SoLuongHocSinh { get => _SoLHocSinh; set => _SoLHocSinh = value; }

    }
}
