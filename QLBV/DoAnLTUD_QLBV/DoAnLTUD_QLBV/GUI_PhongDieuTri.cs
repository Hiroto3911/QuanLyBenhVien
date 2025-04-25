using BUS_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public partial class GUI_PhongDieuTri : Form
    {
        BUS_PhongDieuTri bus_PhongDieuTri = new BUS_PhongDieuTri();
        ET_PhongDieuTri et_PhongDieuTri = new ET_PhongDieuTri();
        public GUI_PhongDieuTri()
        {
            InitializeComponent();
        }

        private void GUI_PhongDieuTri_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_PhongDieuTri.DataSource = bus_PhongDieuTri.getDataFromPhongDieuTri();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_PhongDieuTri.MaPhongDieuTri = txtPDT.Text;
                et_PhongDieuTri.MaBacSiPhuTrach = txtMaBS.Text;
                et_PhongDieuTri.LoaiPhong = txtLoai.Text;
                et_PhongDieuTri.MaKhoa = txtMaK.Text;
                
                if (bus_PhongDieuTri.ThemPhongDieuTri(et_PhongDieuTri) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_PhongDieuTri.DataSource = bus_PhongDieuTri.getDataFromPhongDieuTri();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                et_PhongDieuTri.MaPhongDieuTri = txtPDT.Text;
                et_PhongDieuTri.MaBacSiPhuTrach = txtMaBS.Text;
                et_PhongDieuTri.LoaiPhong = txtLoai.Text;
                et_PhongDieuTri.MaKhoa = txtMaK.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_PhongDieuTri.MaPhongDieuTri}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_PhongDieuTri.XoaPhongDieuTri(et_PhongDieuTri) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_PhongDieuTri.DataSource = bus_PhongDieuTri.getDataFromPhongDieuTri();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                et_PhongDieuTri.MaPhongDieuTri = txtPDT.Text;
                et_PhongDieuTri.MaBacSiPhuTrach = txtMaBS.Text;
                et_PhongDieuTri.LoaiPhong = txtLoai.Text;
                et_PhongDieuTri.MaKhoa = txtMaK.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_PhongDieuTri.MaPhongDieuTri}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_PhongDieuTri.SuaPhongDieuTri(et_PhongDieuTri) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_PhongDieuTri.DataSource = bus_PhongDieuTri.getDataFromPhongDieuTri();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txtMaK.Clear();
            txtLoai.Clear();
            txtMaBS.Clear();
            txtPDT.Clear();

            dgv_PhongDieuTri.DataSource = bus_PhongDieuTri.getDataFromPhongDieuTri();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_PhongDieuTri.DataSource = bus_PhongDieuTri.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }


        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_PhongDieuTri.CurrentCell.RowIndex;
                txtPDT.Text = dgv_PhongDieuTri.Rows[dong].Cells[0].Value.ToString();
                txtLoai.Text = dgv_PhongDieuTri.Rows[dong].Cells[1].Value.ToString();
                txtMaBS.Text = dgv_PhongDieuTri.Rows[dong].Cells[2].Value.ToString();
                txtMaK.Text = dgv_PhongDieuTri.Rows[dong].Cells[3].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_PhongDieuTri_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập mã phòng điều trị cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập mã phòng điều cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }
    }
}
