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
    public class DAL_BenhNhan
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBENHNHAN");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string LayHoTenBN(string id)
        {
            try
            {
                conn.getConnect();
                SqlCommand cmd = new SqlCommand("SP_LAYHOTEN_BENHNHAN", conn.Conn);
                cmd.CommandText = "SP_LAYHOTEN_BENHNHAN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MABN", id));
                SqlDataReader kq = cmd.ExecuteReader();
                if (kq.Read())
                {
                    string hoten = kq[0].ToString();
                    return hoten;
                }
                else
                {
                    return null; 
                }
               

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
                DataTable kq = conn.FindData("SP_TIMBENHNHAN_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable ThongTinChiTietBN(string key)
        {
            try
            {
                conn.getConnect();
                SqlCommand cmd = new SqlCommand("SP_TIMTHONGTINBENHNHAN", conn.Conn);
                cmd.CommandText = "SP_TIMTHONGTINBENHNHAN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MABN", key));
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

        public bool ThemBenhNhan(ET_BenhNhan bn)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMBENHNHAN", conn.Conn);
            cmd.CommandText = "SP_THEMBENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABN", bn.Ma));
            cmd.Parameters.Add(new SqlParameter("HOBN", bn.Ho));
            cmd.Parameters.Add(new SqlParameter("TENBN", bn.Ten));
            cmd.Parameters.Add(new SqlParameter("SODTH", bn.Dth));
            cmd.Parameters.Add(new SqlParameter("DIACHI", bn.DiaChi));
            cmd.Parameters.Add(new SqlParameter("NGAYSINH", bn.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("PHAI", bn.Phai));
            cmd.Parameters.Add(new SqlParameter("MABHYT", bn.Bhyt));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaBenhNhan(ET_BenhNhan bn)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOABENHNHAN", conn.Conn);
            cmd.CommandText = "SP_XOABENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABN", bn.Ma));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;

        }
        public bool SuaBenhNhan(ET_BenhNhan bn)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUABENHNHAN", conn.Conn);
            cmd.CommandText = "SP_SUABENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABN", bn.Ma));
            cmd.Parameters.Add(new SqlParameter("HOBN", bn.Ho));
            cmd.Parameters.Add(new SqlParameter("TENBN", bn.Ten));
            cmd.Parameters.Add(new SqlParameter("SODTH", bn.Dth));
            cmd.Parameters.Add(new SqlParameter("DIACHI", bn.DiaChi));
            cmd.Parameters.Add(new SqlParameter("NGAYSINH", bn.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("PHAI", bn.Phai));
            cmd.Parameters.Add(new SqlParameter("MABHYT", bn.Bhyt));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
