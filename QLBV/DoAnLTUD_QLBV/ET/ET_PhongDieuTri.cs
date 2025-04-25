using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_PhongDieuTri
    {
        private string maPhongDieuTri;
        private string loaiPhong;
        private string maBacSiPhuTrach;
        private string maKhoa;

        public ET_PhongDieuTri()
        {

        }
        public ET_PhongDieuTri(string maPhongDieuTri, string loaiPhong, string maBacSiPhuTrach, string maKhoa)
        {
            this.maPhongDieuTri = maPhongDieuTri;
            this.loaiPhong = loaiPhong;
            this.maBacSiPhuTrach = maBacSiPhuTrach;
            this.maKhoa = maKhoa;
        }

        public string MaPhongDieuTri { get => maPhongDieuTri; set => maPhongDieuTri = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string MaBacSiPhuTrach { get => maBacSiPhuTrach; set => maBacSiPhuTrach = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
