using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLBV;

namespace DAL
{
    public class DAL_SuDungDV
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATSUDUNG_DICHVU");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMSUDUNG_DICHVU_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable LayDuLieuTheoMa(string id)
        {
            try
            {
                conn.getConnect();
                conn.getConnect();
                SqlCommand cmd = new SqlCommand("SP_LAY_SDDV_BANGMA", conn.Conn);
                cmd.CommandText = "SP_LAY_SDDV_BANGMA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAHD", id));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable kq = new DataTable();
                da.Fill(kq);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemSuDungDV(ET_SuDungDichVu suDungDV)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMSUDUNG_DICHVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADV", suDungDV.MaDichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", suDungDV.MaBenhNhan));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", suDungDV.ThoiGian));
            cmd.Parameters.Add(new SqlParameter("@SL", suDungDV.Sl));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaSuDungDV(ET_SuDungDichVu suDungDV)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOASUDUNG_DICHVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADV", suDungDV.MaDichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", suDungDV.MaBenhNhan));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaSuDungDV(ET_SuDungDichVu suDungDV)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUASUDUNG_DICHVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADV", suDungDV.MaDichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", suDungDV.MaBenhNhan));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", suDungDV.ThoiGian));
            cmd.Parameters.Add(new SqlParameter("@SL", suDungDV.Sl));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
