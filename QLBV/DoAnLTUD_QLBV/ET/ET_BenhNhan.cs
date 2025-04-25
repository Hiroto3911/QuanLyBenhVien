using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BenhNhan:ET_Nguoi
    {
        private string dth;
        private string bhyt;
        private string maKhoa; 

        public ET_BenhNhan()
        {
           
        }

   

        public ET_BenhNhan(string ma, string ho, string ten, string diaChi, DateTime ngaySinh, string phai, string dth, string bhyt, string maKhoa) : base(ma, ho, ten, diaChi, ngaySinh, phai)
        {
            this.dth = dth;
            this.bhyt = bhyt;
            this.maKhoa = maKhoa;
        }

        public string Dth { get => dth; set => dth = value; }
        public string Bhyt { get => bhyt; set => bhyt = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
