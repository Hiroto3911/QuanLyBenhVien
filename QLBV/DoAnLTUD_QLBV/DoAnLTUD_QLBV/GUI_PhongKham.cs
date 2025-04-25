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
    public partial class GUI_PhongKham : Form
    {
        public GUI_PhongKham()
        {
            InitializeComponent();
        }

        BUS_PhongKham bus_PhongKham = new BUS_PhongKham();
        ET_PhongKham et_PhongKham = new ET_PhongKham();
        private void GUI_PhongKham_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_PhongKham.DataSource = bus_PhongKham.getDataFromPhongKham();
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
                et_PhongKham.MaPhongKham = txtPDT.Text;
                et_PhongKham.MaBacSiPhuTrach = txtMaBS.Text;
                et_PhongKham.LoaiPhongKham = txtLoaiPK.Text;
                et_PhongKham.MaKhoa = txtMaK.Text;

                if (bus_PhongKham.ThemPhongKham(et_PhongKham) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_PhongKham.DataSource = bus_PhongKham.getDataFromPhongKham();
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

                et_PhongKham.MaPhongKham = txtPDT.Text;
                et_PhongKham.MaBacSiPhuTrach = txtMaBS.Text;
                et_PhongKham.LoaiPhongKham = txtLoaiPK.Text;
                et_PhongKham.MaKhoa = txtMaK.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_PhongKham.MaPhongKham}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_PhongKham.XoaPhongKham(et_PhongKham) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_PhongKham.DataSource = bus_PhongKham.getDataFromPhongKham();
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
                et_PhongKham.MaPhongKham = txtPDT.Text;
                et_PhongKham.MaBacSiPhuTrach = txtMaBS.Text;
                et_PhongKham.LoaiPhongKham = txtLoaiPK.Text;
                et_PhongKham.MaKhoa = txtMaK.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_PhongKham.MaPhongKham}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_PhongKham.SuaPhongKham(et_PhongKham) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_PhongKham.DataSource = bus_PhongKham.getDataFromPhongKham();
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
            txtLoaiPK.Clear();
            txtMaBS.Clear();
            txtPDT.Clear();

            dgv_PhongKham.DataSource = bus_PhongKham.getDataFromPhongKham();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_PhongKham.DataSource = bus_PhongKham.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }


        private void dgv_PhongKham_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_PhongKham.CurrentCell.RowIndex;
                txtPDT.Text = dgv_PhongKham.Rows[dong].Cells[0].Value.ToString();
                txtLoaiPK.Text = dgv_PhongKham.Rows[dong].Cells[3].Value.ToString();
                txtMaBS.Text = dgv_PhongKham.Rows[dong].Cells[2].Value.ToString();
                txtMaK.Text = dgv_PhongKham.Rows[dong].Cells[1].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_PhongKham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập mã phòng khám cần tìm")
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
