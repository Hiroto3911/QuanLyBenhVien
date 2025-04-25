using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BenhNhan_PhongDieuTri
    {
        private string maBN;
        private string pgDT;
        private DateTime ngayNhapVien;
        private DateTime ngayXuatVien;

        public ET_BenhNhan_PhongDieuTri()
        {
            
        }
        public ET_BenhNhan_PhongDieuTri(string maBN, string pgDT, DateTime ngayNhapVien, DateTime ngayXuatVien)
        {
            this.maBN = maBN;
            this.pgDT = pgDT;
            this.ngayNhapVien = ngayNhapVien;
            this.ngayXuatVien = ngayXuatVien;
        }

        public string MaBN { get => maBN; set => maBN = value; }
        public string PgDT { get => pgDT; set => pgDT = value; }
        public DateTime NgayNhapVien { get => ngayNhapVien; set => ngayNhapVien = value; }
        public DateTime NgayXuatVien { get => ngayXuatVien; set => ngayXuatVien = value; }
    }
}
