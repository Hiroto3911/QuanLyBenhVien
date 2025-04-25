using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_Khoa
    {
        private string maKhoa;
        private string tenKhoa;
        private string maBacsiTruongkhoa;

        public ET_Khoa()
        {
           
        }

        public ET_Khoa(string maKhoa, string tenKhoa, string maBacsiTruongkhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.maBacsiTruongkhoa = maBacsiTruongkhoa;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public string MaBacsiTruongkhoa { get => maBacsiTruongkhoa; set => maBacsiTruongkhoa = value; }
    }
}
