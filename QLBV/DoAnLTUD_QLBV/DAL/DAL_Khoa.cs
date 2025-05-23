﻿using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Khoa
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATKHOA");
            conn.getClose();
            return dt;
        }
        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMKHOA_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemKhoa(ET_Khoa khoa)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMKHOA", conn.Conn);
            cmd.CommandText = "SP_THEMKHOA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoa.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("@TENK", khoa.TenKhoa));
            cmd.Parameters.Add(new SqlParameter("@TRUONGKHOA", khoa.MaBacsiTruongkhoa));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool XoaKHoa(ET_Khoa khoa)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOAKHOA", conn.Conn);
            cmd.CommandText = "SP_XOAKHOA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoa.MaKhoa));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool SuaKhoa(ET_Khoa khoa)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUAKHOA", conn.Conn);
            cmd.CommandText = "SP_SUAKHOA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAK", khoa.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("@TENK", khoa.TenKhoa));
            cmd.Parameters.Add(new SqlParameter("@TRUONGKHOA", khoa.MaBacsiTruongkhoa));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
    }
}
