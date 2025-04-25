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
    public class BUS_CHITIET_HOADON
    {
        DAL_ChiTiet_HoaDon dal_chitiet_hoadon = new DAL_ChiTiet_HoaDon();
        public DataTable getData()
        {
            return dal_chitiet_hoadon.LoadData();
        }
        public bool ThemChiTietHoaDon(ET_ChiTietHoaDon ct)
        {
            return dal_chitiet_hoadon.ThemCTHD(ct);
        }
        public bool XoaChiTietHoaDon(ET_ChiTietHoaDon ct)
        {
            return dal_chitiet_hoadon.XoaCTHD(ct);
        }
        public bool SuaChiTietHoaDon(ET_ChiTietHoaDon ct)
        {
            return dal_chitiet_hoadon.SuaCTHD(ct);
        }
        public DataTable FindData(string key)
        {
            return dal_chitiet_hoadon.FindData(key);
        }
    }
}
