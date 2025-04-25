using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET_QLBV;

namespace BUS_QLBV
{
    public class BUS_DichVu
    {
        DAL_DichVu dal_dv = new DAL_DichVu();
        public DataTable getData()
        {
            return dal_dv.getData();
        }
        public string LayTenDichVu(string id)
        {
            return dal_dv.layTenDichVu(id);
        }
        public bool ThemDichVu(ET_DichVu dv)
        {
            return dal_dv.ThemDichVu(dv);
        }
        public bool XoaDichVu(ET_DichVu dv)
        {
            return dal_dv.XoaDichVu(dv);
        }
        public bool SuaDichVu(ET_DichVu dv)
        {
            return dal_dv.SuaDichVu(dv);
        }
        public DataTable FindData(string key)
        {
            return dal_dv.FindData(key);
        }
    }
}
