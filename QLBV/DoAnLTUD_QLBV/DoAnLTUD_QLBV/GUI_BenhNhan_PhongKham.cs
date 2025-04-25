using BUS;
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

namespace DoAnLTUD_QLBV
{
    public partial class GUI_BenhNhan_PhongKham : Form
    {
        public GUI_BenhNhan_PhongKham()
        {
            InitializeComponent();
        }

        BUS_BenhNhan_PhongKham bus_BenhNhan_PhongKham = new BUS_BenhNhan_PhongKham();
        ET_BenhNhan_PhongKham et_BenhNhan_PhongKham = new ET_BenhNhan_PhongKham();
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        BUS_PhongKham BUS_PhongKham = new BUS_PhongKham();
        private void GUI_PhongKham_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_BN_PK.DataSource = bus_BenhNhan_PhongKham.getData();

                cbo_BN.DataSource = BUS_BenhNhan.getData();
                cbo_BN.ValueMember = "MABN";
                cbo_BN.DisplayMember = "MABN";
                cbo_PK.DataSource = BUS_PhongKham.getDataFromPhongKham();
                cbo_PK.ValueMember = "MAPK";
                cbo_PK.DisplayMember = "MAPK";
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
                et_BenhNhan_PhongKham.MaPK = cbo_PK.SelectedValue.ToString();
                et_BenhNhan_PhongKham.MaBN = cbo_BN.SelectedValue.ToString();
                et_BenhNhan_PhongKham.NgayKham = dtp_NgayKham.Value;

                if (bus_BenhNhan_PhongKham.ThemBenhNhan(et_BenhNhan_PhongKham) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_BN_PK.DataSource = bus_BenhNhan_PhongKham.getData();
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

                et_BenhNhan_PhongKham.MaPK = cbo_PK.SelectedValue.ToString();
                et_BenhNhan_PhongKham.MaBN = cbo_BN.SelectedValue.ToString();
                et_BenhNhan_PhongKham.NgayKham = dtp_NgayKham.Value;

                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_BenhNhan_PhongKham.MaBN}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BenhNhan_PhongKham.XoaBenhNhan(et_BenhNhan_PhongKham) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_BN_PK.DataSource = bus_BenhNhan_PhongKham.getData();
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
                et_BenhNhan_PhongKham.MaPK = cbo_PK.SelectedValue.ToString();
                et_BenhNhan_PhongKham.MaBN = cbo_BN.SelectedValue.ToString();
                et_BenhNhan_PhongKham.NgayKham = dtp_NgayKham.Value;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_BenhNhan_PhongKham.MaBN}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BenhNhan_PhongKham.SuaBenhNhan(et_BenhNhan_PhongKham) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_BN_PK.DataSource = bus_BenhNhan_PhongKham.getData();
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
            cbo_PK.SelectedIndex = 0;
            cbo_BN.SelectedIndex = 0;
            dtp_NgayKham.Value = DateTime.Now;
            dgv_BN_PK.DataSource = bus_BenhNhan_PhongKham.getData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_BN_PK.DataSource = bus_BenhNhan_PhongKham.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }


        private void dgv_PhongKham_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_BN_PK.CurrentCell.RowIndex;
                cbo_BN.SelectedValue = dgv_BN_PK.Rows[dong].Cells[0].Value.ToString();
                cbo_PK.SelectedValue = dgv_BN_PK.Rows[dong].Cells[1].Value.ToString();
                dtp_NgayKham.Text = dgv_BN_PK.Rows[dong].Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_BenhNhan_PhongKham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập mã bệnh nhân cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập mã bệnh nhân cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }
    }
}
