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
    public class BUS_BenhNhan_PhongKham
    {
        DAL_BenhNhan_PhongKham Dal_benhnhan_PhongKham = new DAL_BenhNhan_PhongKham();
        public DataTable getData()
        {
            return Dal_benhnhan_PhongKham.getData();
        }
        public bool ThemBenhNhan(ET_BenhNhan_PhongKham bn)
        {
            return Dal_benhnhan_PhongKham.ThemPKhamBenhNhan(bn);
        }
        public bool XoaBenhNhan(ET_BenhNhan_PhongKham bn)
        {
            return Dal_benhnhan_PhongKham.XoaPKhamBenhNhan(bn);
        }
        public bool SuaBenhNhan(ET_BenhNhan_PhongKham bn)
        {
            return Dal_benhnhan_PhongKham.SuaPKhamBenhNhan(bn);
        }
        public DataTable FindData(string key)
        {
            return Dal_benhnhan_PhongKham.FindData(key);
        }
    }
}
