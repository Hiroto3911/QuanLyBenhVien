using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_MuaThuoc
    {
        private string maThuoc;
        private string maBenhNhan;
        private int sl;
        private string maBacSi; 

        public ET_MuaThuoc()
        {
            
        }
        public ET_MuaThuoc(string maThuoc, string maBenhNhan, int sl, string maBacSi)
        {
            this.maThuoc = maThuoc;
            this.maBenhNhan = maBenhNhan;
            this.sl = sl;
            this.maBacSi = maBacSi;
        }

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public int Sl { get => sl; set => sl = value; }
        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
    }
}
