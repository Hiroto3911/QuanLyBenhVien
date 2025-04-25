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
    public class DAL_Thuoc
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATTHUOC");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string layTenThuoc(string id )
        {
            try
            {
                conn.getConnect();
                SqlCommand cmd = new SqlCommand("SP_LAYTENTHUOC", conn.Conn);
                cmd.CommandText = "SP_LAYTENTHUOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", id));
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
                DataTable kq = conn.FindData("SP_TIMTHUOC_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemThuoc(ET_Thuoc thuoc)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMTHUOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MATHUOC", thuoc.MaThuoc));
            cmd.Parameters.Add(new SqlParameter("@TENTHUOC", thuoc.TenThuoc));
            cmd.Parameters.Add(new SqlParameter("@GIA", thuoc.Gia));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaThuoc(ET_Thuoc thuoc)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOATHUOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MATHUOC", thuoc.MaThuoc));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaThuoc(ET_Thuoc thuoc)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUATHUOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MATHUOC", thuoc.MaThuoc));
            cmd.Parameters.Add(new SqlParameter("@TENTHUOC", thuoc.TenThuoc));
            cmd.Parameters.Add(new SqlParameter("@GIA", thuoc.Gia));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
