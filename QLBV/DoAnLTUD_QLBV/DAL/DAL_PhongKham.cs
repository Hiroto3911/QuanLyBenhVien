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
    public class DAL_PhongKham
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATPHONGKHAM");
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
                DataTable kq = conn.FindData("SP_TIMPHONGKHAM_BANGTENKHOA", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemPhongKham(ET_PhongKham phongKham)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMPHONGKHAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", phongKham.MaPhongKham));
            cmd.Parameters.Add(new SqlParameter("@MAK", phongKham.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("@BS", phongKham.MaBacSiPhuTrach));
            cmd.Parameters.Add(new SqlParameter("@LOAIPK", phongKham.LoaiPhongKham));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaPhongKham(ET_PhongKham phongKham)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOAPHONGKHAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", phongKham.MaPhongKham));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaPhongKham(ET_PhongKham phongKham)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUAPHONGKHAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", phongKham.MaPhongKham));
            cmd.Parameters.Add(new SqlParameter("@MAK", phongKham.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("@BS", phongKham.MaBacSiPhuTrach));
            cmd.Parameters.Add(new SqlParameter("@LOAIPK", phongKham.LoaiPhongKham));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
