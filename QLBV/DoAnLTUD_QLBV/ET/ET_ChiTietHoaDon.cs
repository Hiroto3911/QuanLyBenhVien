using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_ChiTietHoaDon
    {
        private string maHD;
        private string maLoai;
        private string tenLoai;
        private int sl;
        private double thanhTien;
        private string maBS; 

        public ET_ChiTietHoaDon()
        {
        }

        public ET_ChiTietHoaDon(string maHD, string maLoai, string tenLoai, int sl, double thanhTien)
        {
            this.maHD = maHD;
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.sl = sl;
            this.thanhTien = thanhTien;
        }

        public ET_ChiTietHoaDon(string maHD, string maLoai, string tenLoai, int sl, double thanhTien, string maBS) : this(maHD, maLoai, tenLoai, sl, thanhTien)
        {
            this.maBS = maBS;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public int Sl { get => sl; set => sl = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string MaBS { get => maBS; set => maBS = value; }
    }
}
