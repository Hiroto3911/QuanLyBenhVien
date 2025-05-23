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
    public class DAL_BenhAn
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBENHAN");
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
                DataTable kq = conn.FindData("SP_TIMBENHAN_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemBenhAn(ET_BenhAn ba)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMBENHAN", conn.Conn);
            cmd.CommandText = "SP_THEMBENHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABA", ba.MaBenhAn));
            cmd.Parameters.Add(new SqlParameter("MABN", ba.MaBenhNhan));
            cmd.Parameters.Add(new SqlParameter("NGAYNHAPVIEN", ba.NgayNhapVien));
            cmd.Parameters.Add(new SqlParameter("NGAYXUATVIEN", ba.NgayXuatVien));
            cmd.Parameters.Add(new SqlParameter("KETQUA", ba.KetQua));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaBenhAn(ET_BenhAn ba)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOABENHAN", conn.Conn);
            cmd.CommandText = "SP_XOABENHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABA", ba.MaBenhAn));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool SuaBenhAn(ET_BenhAn ba)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUABENHAN", conn.Conn);
            cmd.CommandText = "SP_SUABENHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABA", ba.MaBenhAn));
            cmd.Parameters.Add(new SqlParameter("MABN", ba.MaBenhNhan));
            cmd.Parameters.Add(new SqlParameter("NGAYNHAPVIEN", ba.NgayNhapVien));
            cmd.Parameters.Add(new SqlParameter("NGAYXUATVIEN", ba.NgayXuatVien));
            cmd.Parameters.Add(new SqlParameter("KETQUA", ba.KetQua));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
