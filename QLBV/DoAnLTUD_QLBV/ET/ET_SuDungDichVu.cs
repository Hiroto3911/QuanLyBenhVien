using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_SuDungDichVu
    {
        private string maDichVu;
        private string maBenhNhan;
        private DateTime thoiGian;
        private int sl;

        public ET_SuDungDichVu()
        {
            
        }
        public ET_SuDungDichVu(string maDichVu, string maBenhNhan, DateTime thoiGian)
        {
            this.maDichVu = maDichVu;
            this.maBenhNhan = maBenhNhan;
            this.thoiGian = thoiGian;
        }

        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
