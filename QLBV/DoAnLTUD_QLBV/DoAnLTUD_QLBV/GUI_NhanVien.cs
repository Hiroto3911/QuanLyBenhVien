using BUS_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public partial class GUI_NhanVien : Form
    {
        BUS_Khoa bus_khoa = new BUS_Khoa();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        ET_NhanVien et_NhanVien = new ET_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                
                dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();         
                
                cbo_khoa.DataSource = bus_khoa.getDataFromKhoa();
                cbo_khoa.ValueMember = "MAK";
                 cbo_khoa.DisplayMember = "TENK"; 
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        
       

       

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_NhanVien.DataSource = bus_NhanVien.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void dgv_NhanVien_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_NhanVien.CurrentCell.RowIndex;
                txt_ID.Text = dgv_NhanVien.Rows[dong].Cells[0].Value.ToString();
                txt_Ho.Text = dgv_NhanVien.Rows[dong].Cells[1].Value.ToString();
                txt_Ten.Text = dgv_NhanVien.Rows[dong].Cells[2].Value.ToString();
                txt_DC.Text = dgv_NhanVien.Rows[dong].Cells[3].Value.ToString();
                dtpngaysinh.Text = dgv_NhanVien.Rows[dong].Cells[4].Value.ToString();
                cb_phai.Text = dgv_NhanVien.Rows[dong].Cells[5].Value.ToString();
                cbo_ChucVu.Text = dgv_NhanVien.Rows[dong].Cells[6].Value.ToString();
                cbo_vaitro.Text = dgv_NhanVien.Rows[dong].Cells[7].Value.ToString();
                dtp_NgayLamViec.Text = dgv_NhanVien.Rows[dong].Cells[8].Value.ToString();
                cbo_khoa.Text = dgv_NhanVien.Rows[dong].Cells[9].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập tên nhân viên cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên nhân viên cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }

       

        private void btnlm_Click(object sender, EventArgs e)
        {
            
            try
            {
                txt_ID.Clear();
                txt_Ho.Clear();
                txt_Ten.Clear();
                txt_DC.Clear();
                dtpngaysinh.Text = DateTime.Now.ToString();
                cb_phai.Text = null;
                cbo_ChucVu.Text = null;
                cbo_vaitro.Text = null;
                dtp_NgayLamViec.Text = DateTime.Now.ToString();
                cbo_khoa.Text = null;
                dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
                txt_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_t_Click(object sender, EventArgs e)
        {

            try
            {
                et_NhanVien.Ma = txt_ID.Text;
                et_NhanVien.Ho = txt_Ho.Text;
                et_NhanVien.Ten = txt_Ten.Text;
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtpngaysinh.Text);
                et_NhanVien.DiaChi = txt_DC.Text;
                et_NhanVien.Phai = cb_phai.Text;
                et_NhanVien.ChucVu = cbo_ChucVu.Text;
                et_NhanVien.VaiTro = cbo_vaitro.Text;
                et_NhanVien.NgayLamViec = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.MaKhoa = cbo_khoa.SelectedValue.ToString();
                if (bus_NhanVien.ThemNhanVien(et_NhanVien) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            try
            {

                et_NhanVien.Ma = txt_ID.Text;
                et_NhanVien.Ho = txt_Ho.Text;
                et_NhanVien.Ten = txt_Ten.Text;
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtpngaysinh.Text);
                et_NhanVien.DiaChi = txt_DC.Text;
                et_NhanVien.Phai = cb_phai.Text;
                et_NhanVien.ChucVu = cbo_ChucVu.Text;
                et_NhanVien.VaiTro = cbo_vaitro.Text;
                et_NhanVien.NgayLamViec = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.MaKhoa = cbo_khoa.SelectedValue.ToString();
                if (bus_NhanVien.SuaNhanVien(et_NhanVien) == false)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            try
            {

                et_NhanVien.Ma = txt_ID.Text;
                et_NhanVien.Ho = txt_Ho.Text;
                et_NhanVien.Ten = txt_Ten.Text;
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtpngaysinh.Text);
                et_NhanVien.DiaChi = txt_DC.Text;
                et_NhanVien.Phai = cb_phai.Text;
                et_NhanVien.ChucVu = cbo_ChucVu.Text;
                et_NhanVien.VaiTro = cbo_vaitro.Text;
                et_NhanVien.NgayLamViec = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.MaKhoa = cbo_khoa.SelectedValue.ToString();
                if (bus_NhanVien.XoaNhanVien(et_NhanVien) == false)
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");

                }
                dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }
    }
}
