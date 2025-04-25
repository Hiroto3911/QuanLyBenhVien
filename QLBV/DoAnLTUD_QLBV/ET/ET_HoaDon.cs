using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_HoaDon
    {
        private string maHD;
        private string maBenhNhan;
        private double tongTien;
        private DateTime ngayLapHB;

        public ET_HoaDon()
        {
        }

        public ET_HoaDon(string maHD, string maBenhNhan, double tongTien, DateTime ngayLapHB)
        {
            this.maHD = maHD;
            this.maBenhNhan = maBenhNhan;
            this.tongTien = tongTien;
            this.ngayLapHB = ngayLapHB;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayLapHB { get => ngayLapHB; set => ngayLapHB = value; }
    }
}
