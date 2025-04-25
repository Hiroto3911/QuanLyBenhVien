using DAL;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BenhNhan_PhongDieuTri
    {
        DAL_BenhNhan_PhongDieuTri Dal_benhnhan_PhongDieuTri = new DAL_BenhNhan_PhongDieuTri();
        public DataTable getData()
        {
            return Dal_benhnhan_PhongDieuTri.getData();
        }
        public DataTable LocDSBangMaPhong(string key)
        {
            return Dal_benhnhan_PhongDieuTri.LocDSTheoMaPhong(key);
        }
        public bool ThemBenhNhan_PhongDieuTri(ET_BenhNhan_PhongDieuTri bn)
        {
            return Dal_benhnhan_PhongDieuTri.ThemBenhNhan(bn);
        }
        public bool XoaBenhNhan_PhongDieuTri(ET_BenhNhan_PhongDieuTri bn)
        {
            return Dal_benhnhan_PhongDieuTri.XoaBenhNhan(bn);
        }
        public bool SuaBenhNhan(ET_BenhNhan_PhongDieuTri bn)
        {
            return Dal_benhnhan_PhongDieuTri.SuaBenhNhan(bn);
        }
        public DataTable FindData(string key)
        {
            return Dal_benhnhan_PhongDieuTri.FindData(key);
        }
    }
}
