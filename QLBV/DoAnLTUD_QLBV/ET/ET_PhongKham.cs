using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_PhongKham
    {
        private string maPhongKham;
        private string maKhoa;
        private string maBacSiPhuTrach;
        private string loaiPhongKham;

        public ET_PhongKham()
        {
           
        }

        public ET_PhongKham(string maPhongKham, string maKhoa, string maBacSiPhuTrach, string loaiPhongKham)
        {
            this.maPhongKham = maPhongKham;
            this.maKhoa = maKhoa;
            this.maBacSiPhuTrach = maBacSiPhuTrach;
            this.loaiPhongKham = loaiPhongKham;
        }

        public string MaPhongKham { get => maPhongKham; set => maPhongKham = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaBacSiPhuTrach { get => maBacSiPhuTrach; set => maBacSiPhuTrach = value; }
        public string LoaiPhongKham { get => loaiPhongKham; set => loaiPhongKham = value; }
    }
}
