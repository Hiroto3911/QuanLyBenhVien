using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_Nguoi
    {
        private string ma;
        private string ho;
        private string ten;
        private string diaChi;
        private DateTime ngaySinh;
        private string phai;

        public ET_Nguoi()
        {
            
        }

        public ET_Nguoi(string ma, string ho, string ten, string diaChi, DateTime ngaySinh, string phai)
        {
            this.ma = ma;
            this.ho = ho;
            this.ten = ten;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.phai = phai;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Phai { get => phai; set => phai = value; }
    }
}
