using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_Thuoc
    {
        private string maThuoc;
        private string tenThuoc;
        private double gia;

        public ET_Thuoc()
        {
        }

        public ET_Thuoc(string maThuoc, string tenThuoc, double gia)
        {
            this.maThuoc = maThuoc;
            this.tenThuoc = tenThuoc;
            this.gia = gia;
        }

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
