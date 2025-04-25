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
    public class DAL_BenhNhan_PhongKham
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBENHNHAN_PHONGKHAM");
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
                DataTable kq = conn.FindData("SP_TIMPKHAM_BENHNHAN_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemPKhamBenhNhan(ET_BenhNhan_PhongKham pKhamBenhNhan)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMBENHNHAN_PHONGKHAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", pKhamBenhNhan.MaPK));
            cmd.Parameters.Add(new SqlParameter("@MABN", pKhamBenhNhan.MaBN));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", pKhamBenhNhan.NgayKham));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaPKhamBenhNhan(ET_BenhNhan_PhongKham pKhamBenhNhan)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOABENHNHAN_PHONGKHAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", pKhamBenhNhan.MaPK));
            cmd.Parameters.Add(new SqlParameter("@MABN", pKhamBenhNhan.MaBN));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaPKhamBenhNhan(ET_BenhNhan_PhongKham pKhamBenhNhan)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUABENHNHAN_PHONGKHAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", pKhamBenhNhan.MaPK));
            cmd.Parameters.Add(new SqlParameter("@MABN", pKhamBenhNhan.MaBN));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", pKhamBenhNhan.NgayKham));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
