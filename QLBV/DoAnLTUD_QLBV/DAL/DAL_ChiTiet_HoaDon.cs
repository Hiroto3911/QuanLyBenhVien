using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTiet_HoaDon
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATCHITIET_HOADON");
            conn.getClose();
            return dt;
        }
        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMKIEM_HOADONCHITIET_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemCTHD(ET_ChiTietHoaDon cthoadon)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEM_CHITIET_HOADON", conn.Conn);
            cmd.CommandText = "SP_THEM_CHITIET_HOADON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", cthoadon.MaHD));
            cmd.Parameters.Add(new SqlParameter("@MAL", cthoadon.MaLoai));
            cmd.Parameters.Add(new SqlParameter("@TENL", cthoadon.TenLoai));
            cmd.Parameters.Add(new SqlParameter("@SL", cthoadon.Sl));
            cmd.Parameters.Add(new SqlParameter("@MABS", cthoadon.MaBS));

            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool XoaCTHD(ET_ChiTietHoaDon cthoadon)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOA_CHITIET_HOADON", conn.Conn);
            cmd.CommandText = "SP_XOA_CHITIET_HOADON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", cthoadon.MaHD));
            cmd.Parameters.Add(new SqlParameter("@MAL", cthoadon.MaLoai));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool SuaCTHD(ET_ChiTietHoaDon cthoadon)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUA_CHITIET_HOADON", conn.Conn);
            cmd.CommandText = "SP_SUA_CHITIET_HOADON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", cthoadon.MaHD));
            cmd.Parameters.Add(new SqlParameter("@MAL", cthoadon.MaLoai));
            cmd.Parameters.Add(new SqlParameter("@TENL", cthoadon.TenLoai));
            cmd.Parameters.Add(new SqlParameter("@SL", cthoadon.Sl));
            cmd.Parameters.Add(new SqlParameter("@MABS", cthoadon.MaBS));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
    }
}
