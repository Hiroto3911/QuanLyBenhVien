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
    public class DAL_BenhNhan_PhongDieuTri
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBENHNHAN_PHONGDIEUTRI");
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
        public DataTable LocDSTheoMaPhong(string key)
        {
            try
            {
                conn.getConnect();
                SqlCommand cmd = new SqlCommand("SO_LOCDS_BANGMAPHG", conn.Conn);
                cmd.CommandText = "SO_LOCDS_BANGMAPHG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPDT", key));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }catch(Exception ex) { throw ex; }  
        }
        public bool ThemBenhNhan(ET_BenhNhan_PhongDieuTri bnpdt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMBENHNHAN_PHONGDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABN", bnpdt.MaBN));
            cmd.Parameters.Add(new SqlParameter("@PHGDT", bnpdt.PgDT));
            cmd.Parameters.Add(new SqlParameter("@NGAYNHAPVIEN", bnpdt.NgayNhapVien));
   
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaBenhNhan(ET_BenhNhan_PhongDieuTri bnpdt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOABENHNHAN_PHONGDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABN", bnpdt.MaBN));
            cmd.Parameters.Add(new SqlParameter("@PHGDT", bnpdt.PgDT));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaBenhNhan(ET_BenhNhan_PhongDieuTri bnpdt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUABENHNHAN_PHONGDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MABN", bnpdt.MaBN));
            cmd.Parameters.Add(new SqlParameter("@PHGDT", bnpdt.PgDT));
            cmd.Parameters.Add(new SqlParameter("@NGAYNHAPVIEN", bnpdt.NgayNhapVien));
            cmd.Parameters.Add(new SqlParameter("@NGAYXUATVIEN", bnpdt.NgayXuatVien));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
