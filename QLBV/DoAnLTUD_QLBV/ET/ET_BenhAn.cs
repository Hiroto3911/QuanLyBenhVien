using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBV
{
    public class ET_BenhAn
    {
        private string maBenhAn;
        private string maBenhNhan;
        private DateTime ngayNhapVien;
        private DateTime ngayXuatVien;
        private string ketQua;

        public ET_BenhAn()
        {

        }
            public ET_BenhAn(string maBenhAn, string maBenhNhan, DateTime ngayNhapVien, DateTime ngayXuatVien, string ketQua)
        {
            this.maBenhAn = maBenhAn;
            this.maBenhNhan = maBenhNhan;
            this.ngayNhapVien = ngayNhapVien;
            this.ngayXuatVien = ngayXuatVien;
            this.ketQua = ketQua;
        }

        public string MaBenhAn { get => maBenhAn; set => maBenhAn = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public DateTime NgayNhapVien { get => ngayNhapVien; set => ngayNhapVien = value; }
        public DateTime NgayXuatVien { get => ngayXuatVien; set => ngayXuatVien = value; }
        public string KetQua { get => ketQua; set => ketQua = value; }
    }
}
