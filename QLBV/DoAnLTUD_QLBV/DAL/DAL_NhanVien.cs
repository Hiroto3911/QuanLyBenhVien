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
    public class DAL_NhanVien
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATNHANVIEN");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getDataBS()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_LAYDS_BACSI");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // CẦN THÌ GỠ BỎ PHONG ẤN
        //public DataTable getDataNV()
        //{
        //    try
        //    {
        //        conn.getConnect();
        //        DataTable kq = conn.LoadData("SP_LAYDS_BACSI");
        //        conn.getClose();
        //        return kq;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMNHANVIEN_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemNhanVien(ET_NhanVien nhanVien)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", nhanVien.Ma));
            cmd.Parameters.Add(new SqlParameter("@HONV", nhanVien.Ho));
            cmd.Parameters.Add(new SqlParameter("@TENNV", nhanVien.Ten));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", nhanVien.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", nhanVien.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@PHAI", nhanVien.Phai));
            cmd.Parameters.Add(new SqlParameter("@CHUCVU", nhanVien.ChucVu));
            cmd.Parameters.Add(new SqlParameter("@VAITRO", nhanVien.VaiTro));
            cmd.Parameters.Add(new SqlParameter("@NGAYLV", nhanVien.NgayLamViec));
            cmd.Parameters.Add(new SqlParameter("@MAKHOA", nhanVien.MaKhoa));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaNhanVien(ET_NhanVien nhanVien)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", nhanVien.Ma));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaNhanVien(ET_NhanVien nhanVien)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", nhanVien.Ma));
            cmd.Parameters.Add(new SqlParameter("@HONV", nhanVien.Ho));
            cmd.Parameters.Add(new SqlParameter("@TENNV", nhanVien.Ten));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", nhanVien.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", nhanVien.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@PHAI", nhanVien.Phai));
            cmd.Parameters.Add(new SqlParameter("@CHUCVU", nhanVien.ChucVu));
            cmd.Parameters.Add(new SqlParameter("@VAITRO", nhanVien.VaiTro));
            cmd.Parameters.Add(new SqlParameter("@NGAYLV", nhanVien.NgayLamViec));
            cmd.Parameters.Add(new SqlParameter("@MAKHOA", nhanVien.MaKhoa));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
