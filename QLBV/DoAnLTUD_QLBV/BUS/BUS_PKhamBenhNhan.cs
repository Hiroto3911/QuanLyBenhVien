using DAL;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBV
{
    public class BUS_PKhamBenhNhan
    {
        DAL_BenhNhan_PhongKham dal_pKhamBenhNhan = new DAL_BenhNhan_PhongKham();

        public DataTable getDataFromPKhamBenhNhan()
        {
            return dal_pKhamBenhNhan.getData();
        }

        public bool ThemPKhamBenhNhan(ET_BenhNhan_PhongKham et_PKhamBenhNhan)
        {
            return dal_pKhamBenhNhan.ThemPKhamBenhNhan(et_PKhamBenhNhan);
        }

        public bool XoaPKhamBenhNhan(ET_BenhNhan_PhongKham et_PKhamBenhNhan)
        {
            return dal_pKhamBenhNhan.XoaPKhamBenhNhan(et_PKhamBenhNhan);
        }

        public bool SuaPKhamBenhNhan(ET_BenhNhan_PhongKham et_PKhamBenhNhan)
        {
            return dal_pKhamBenhNhan.SuaPKhamBenhNhan(et_PKhamBenhNhan);
        }
        public DataTable FindData(string key)
        {
            return dal_pKhamBenhNhan.FindData(key);
        }
    }
}
