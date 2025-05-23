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
    public class DAL_PhongDieuTri
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATPHONGDIEUTRI");
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
                DataTable kq = conn.FindData("SP_TIMPHONGDIEUTRI_BANGLOAIPHG", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemPhongDieuTri(ET_PhongDieuTri phongDieuTri)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMPHONGDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPDT", phongDieuTri.MaPhongDieuTri));
            cmd.Parameters.Add(new SqlParameter("@LOAIPHONG", phongDieuTri.LoaiPhong));
            cmd.Parameters.Add(new SqlParameter("@MABS", phongDieuTri.MaBacSiPhuTrach));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaPhongDieuTri(ET_PhongDieuTri phongDieuTri)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOAPHONGDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPDT", phongDieuTri.MaPhongDieuTri));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaPhongDieuTri(ET_PhongDieuTri phongDieuTri)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUAPHONGDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPDT", phongDieuTri.MaPhongDieuTri));
            cmd.Parameters.Add(new SqlParameter("@LOAIPHONG", phongDieuTri.LoaiPhong));
            cmd.Parameters.Add(new SqlParameter("@MABS", phongDieuTri.MaBacSiPhuTrach));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
