
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
    public class BUS_Thuoc
    {
        DAL_Thuoc dal_thuoc = new DAL_Thuoc();

        public DataTable getDataFromThuoc()
        {
            return dal_thuoc.getData();
        }

        public string LayTenThuoc (string id)
        {
            return dal_thuoc.layTenThuoc(id);
        }
        public bool ThemThuoc(ET_Thuoc et_Thuoc)
        {
            return dal_thuoc.ThemThuoc(et_Thuoc);
        }

        public bool XoaThuoc(ET_Thuoc et_Thuoc)
        {
            return dal_thuoc.XoaThuoc(et_Thuoc);
        }

        public bool SuaThuoc(ET_Thuoc et_Thuoc)
        {
            return dal_thuoc.SuaThuoc(et_Thuoc);
        }
        public DataTable FindData(string key)
        {
            return dal_thuoc.FindData(key);
        }
    }
}
