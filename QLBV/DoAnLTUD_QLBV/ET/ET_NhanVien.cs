using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_NhanVien:ET_Nguoi
    {
        private DateTime ngayLamViec;
        private string chucVu;
        private string vaiTro;
        private string maKhoa;
    


        public ET_NhanVien()
        {
            
        }

        public ET_NhanVien(string ma, string ho, string ten, string dth, string diaChi, DateTime ngaySinh, string phai, DateTime ngayLamViec, string chucVu, string vaiTro, DateTime ngayBDLamViec,string maKhoa) : base(ma, ho, ten, diaChi, ngaySinh, phai)
        {
            this.ngayLamViec = ngayLamViec;
            this.chucVu = chucVu;
            this.vaiTro = vaiTro;
            this.maKhoa = maKhoa;
            
        }

        public DateTime NgayLamViec { get => ngayLamViec; set => ngayLamViec = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string VaiTro { get => vaiTro; set => vaiTro = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
