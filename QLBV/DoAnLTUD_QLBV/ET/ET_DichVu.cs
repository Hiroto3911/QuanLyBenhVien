using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_DichVu
    {
        private string maDichVu;
        private string tenDichVu;
        private double gia;

        public ET_DichVu()
        {
            
        }
        public ET_DichVu(string maDichVu, string tenDichVu, double gia)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.gia = gia;
        }

        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
