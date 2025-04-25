using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET_QLBV;

namespace BUS_QLBV
{
    public class BUS_BenhNhan
    {
        DAL_BenhNhan Dal_benhnhan = new DAL_BenhNhan();
        public DataTable getData()
        {
            return Dal_benhnhan.getData();
        }
        public string LayHoTenBN(string id)
        {
            return Dal_benhnhan.LayHoTenBN(id);
        }
        public bool ThemBenhNhan(ET_BenhNhan bn)
        {
            return Dal_benhnhan.ThemBenhNhan(bn);
        }
        public bool XoaBenhNhan(ET_BenhNhan bn)
        {
            return Dal_benhnhan.XoaBenhNhan(bn);
        }
        public bool SuaBenhNhan(ET_BenhNhan bn)
        {
            return Dal_benhnhan.SuaBenhNhan(bn);
        }
        public DataTable FindData(string key)
        {
            return Dal_benhnhan.FindData(key);
        }
        public DataTable ThongTinChiTietBN(string key)
        {
           
            return Dal_benhnhan.ThongTinChiTietBN(key);

        }
    }
}
