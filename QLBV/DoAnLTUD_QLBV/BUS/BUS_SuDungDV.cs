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
    public class BUS_SuDungDV
    {
        DAL_SuDungDV dal_suDungDV = new DAL_SuDungDV();

        public DataTable getDataFromSuDungDV()
        {
            return dal_suDungDV.getData();
        }

        public DataTable LayDuLieuBangMa(string id)
        {
            return dal_suDungDV.LayDuLieuTheoMa(id);
        }
        public bool ThemSuDungDV(ET_SuDungDichVu et_SuDungDV)
        {
            return dal_suDungDV.ThemSuDungDV(et_SuDungDV);
        }

        public bool XoaSuDungDV(ET_SuDungDichVu et_SuDungDV)
        {
            return dal_suDungDV.XoaSuDungDV(et_SuDungDV);
        }

        public bool SuaSuDungDV(ET_SuDungDichVu et_SuDungDV)
        {
            return dal_suDungDV.SuaSuDungDV(et_SuDungDV);
        }
        public DataTable FindData(string key)
        {
            return dal_suDungDV.FindData(key);
        }
    }
}
