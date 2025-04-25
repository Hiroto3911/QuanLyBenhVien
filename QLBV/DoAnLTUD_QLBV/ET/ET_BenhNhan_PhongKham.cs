using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BenhNhan_PhongKham
    {
        private string maBN;
        private string maPK;
        private DateTime ngayKham;

        public ET_BenhNhan_PhongKham()
        {
        }

        public ET_BenhNhan_PhongKham(string maBN, string maPK, DateTime ngayKham)
        {
            this.maBN = maBN;
            this.maPK = maPK;
            this.ngayKham = ngayKham;
        }

        public string MaBN { get => maBN; set => maBN = value; }
        public string MaPK { get => maPK; set => maPK = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
    }
}
