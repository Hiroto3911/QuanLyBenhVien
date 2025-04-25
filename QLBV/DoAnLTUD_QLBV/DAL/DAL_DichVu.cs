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
    public class DAL_DichVu
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATDICHVU");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string layTenDichVu(string id)
        {
            try
            {
                conn.getConnect();
                SqlCommand cmd = new SqlCommand("SP_LAYTENDV", conn.Conn);
                cmd.CommandText = "SP_LAYTENDV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MADV", id));
                SqlDataReader kp = cmd.ExecuteReader();
                if (kp.Read())
                {
                    return kp[0].ToString();
                }
                else return null;
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
                DataTable kq = conn.FindData("SP_TIMDICHVU_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemDichVu(ET_DichVu dv)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMDV", conn.Conn);
            cmd.CommandText = "SP_THEMDV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MADV", dv.MaDichVu));
            cmd.Parameters.Add(new SqlParameter("TENDV", dv.TenDichVu));
            cmd.Parameters.Add(new SqlParameter("GIA", dv.Gia));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaDichVu(ET_DichVu dv)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOADV", conn.Conn);
            cmd.CommandText = "SP_XOADV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MADV", dv.MaDichVu));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;

        }
        public bool SuaDichVu(ET_DichVu dv)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUADV", conn.Conn);
            cmd.CommandText = "SP_SUADV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MADV", dv.MaDichVu));
            cmd.Parameters.Add(new SqlParameter("TENDV", dv.TenDichVu));
            cmd.Parameters.Add(new SqlParameter("GIA", dv.Gia));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
