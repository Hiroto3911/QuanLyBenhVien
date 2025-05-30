﻿
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
    public class BUS_Khoa
    {
        DAL_Khoa dal_khoa = new DAL_Khoa();
        public DataTable getDataFromKhoa()
        {
            return dal_khoa.LoadData();
        }
        public bool ThemKhoa(ET_Khoa et_Khoa)
        {
            return dal_khoa.ThemKhoa(et_Khoa);
        }
        public bool XoaKhoa(ET_Khoa et_Khoa)
        {
            return dal_khoa.XoaKHoa(et_Khoa);
        }
        public bool SuaKhoa(ET_Khoa et_Khoa)
        {
            return dal_khoa.SuaKhoa(et_Khoa);
        }
        public DataTable FindData(string key)
        {
            return dal_khoa.FindData(key);
        }
    }
}
