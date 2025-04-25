using BUS;
using BUS_QLBV;
using ET_QLBV;
using GUI_QLBV;
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
    public partial class GUI_CHITIET_HOADON : Form
    {

        BUS_CHITIET_HOADON bus_ct = new BUS_CHITIET_HOADON();
        BUS_Thuoc BUS_Thuoc = new BUS_Thuoc();
        BUS_MuaThuoc BUS_MuaThuoc = new BUS_MuaThuoc();
        BUS_SuDungDV BUS_SuDungDV = new BUS_SuDungDV();
        BUS_DichVu BUS_DichVu = new BUS_DichVu();
        ET_ChiTietHoaDon et_ct = new ET_ChiTietHoaDon();
        BUS_HoaDon BUS_HoaDon = new BUS_HoaDon();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        public GUI_CHITIET_HOADON()
        {
            InitializeComponent();
        }

        private void GUI_CHITIET_HOADON_Load(object sender, EventArgs e)
        {
            try
            {
                string[] arr = new string[] { "Thuốc", "Dịch vụ" };
                cbo_Loai.DataSource = arr;
                dgv_ChiTietHoaDon.DataSource = bus_ct.getData();
                cbo_MaHD.DataSource = BUS_HoaDon.getMaHD();
                cbo_MaHD.ValueMember = "MAHD";
                cbo_MaHD.DisplayMember = "MAHD";
                cbo_BacSi.DataSource = BUS_NhanVien.getDataBS();
                cbo_BacSi.ValueMember = "MANV";
                cbo_BacSi.DisplayMember = "HOTEN";
                lb_MaBS.Text = cbo_BacSi.SelectedValue.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void cbo_Loai_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbo_Loai.SelectedValue.ToString())
            {
                case "Dịch vụ":
                    cbo_MaL.DataSource = BUS_DichVu.getData();
                    cbo_MaL.ValueMember = "MADV";
                    cbo_MaL.DisplayMember = "MADV";
                    lb_BS.Visible = false;
                    lb_MaBS.Visible = false;
                    cbo_BacSi.Visible = false;

                    break;
                case "Thuốc":
                    cbo_MaL.DataSource = BUS_Thuoc.getDataFromThuoc();
                    cbo_MaL.ValueMember = "MATHUOC";
                    cbo_MaL.DisplayMember = "MATHUOC";
                    lb_BS.Visible = true;
                    lb_MaBS.Visible = true;
                    cbo_BacSi.Visible = true;

                    break;
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            et_ct.MaHD = cbo_MaHD.SelectedValue.ToString();
            et_ct.MaLoai = cbo_MaL.SelectedValue.ToString();
            et_ct.TenLoai = txt_name.Text;
            et_ct.Sl = Convert.ToInt32(txt_SL.Text);
            et_ct.MaBS = cbo_BacSi.SelectedValue.ToString();
   
            try
            {
                if (bus_ct.ThemChiTietHoaDon(et_ct) == true)
                {
                    MessageBox.Show($"THÊM THÀNH CÔNG ", "Thông báo");
                    dgv_ChiTietHoaDon.DataSource = bus_ct.getData();
                }
                else
                {
                    MessageBox.Show($"XOÁ THÀNH CÔNG ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            et_ct.MaHD = cbo_MaHD.SelectedValue.ToString();
            et_ct.MaLoai = cbo_MaL.SelectedValue.ToString();
            et_ct.TenLoai = txt_name.Text;
            et_ct.Sl = Convert.ToInt32(txt_SL.Text);

            try
            {
                if (bus_ct.XoaChiTietHoaDon(et_ct) == true)
                {
                    MessageBox.Show($"XOÁ THÀNH CÔNG ", "Thông báo");
                    dgv_ChiTietHoaDon.DataSource = bus_ct.getData();
                }
                else
                {
                    MessageBox.Show($"XOÁ THÀNH CÔNG ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            et_ct.MaHD = cbo_MaHD.SelectedValue.ToString();
            et_ct.MaLoai = cbo_MaL.SelectedValue.ToString();
            et_ct.TenLoai = txt_name.Text;
            et_ct.MaBS = cbo_BacSi.SelectedValue.ToString();
            et_ct.Sl = Convert.ToInt32(txt_SL.Text);
            try
            {
                if (bus_ct.SuaChiTietHoaDon(et_ct) == true)
                {
                    MessageBox.Show($" SỬA THÀNH CÔNG ", "Thông báo");
                    dgv_ChiTietHoaDon.DataSource = bus_ct.getData();
                }
                else
                {
                    MessageBox.Show($"SỬA THÀNH CÔNG ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            cbo_MaHD.SelectedIndex = 0;
            cbo_Loai.SelectedIndex = 0;
            txt_ThanhTien.Clear();
            txt_SL.Clear();
            dgv_ChiTietHoaDon.DataSource = bus_ct.getData();
            cbo_MaHD.DataSource = BUS_HoaDon.getMaHD();
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            cbo_BacSi.DataSource = BUS_NhanVien.getDataBS();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_ChiTietHoaDon.CurrentCell.RowIndex;
                cbo_MaHD.SelectedValue = dgv_ChiTietHoaDon.Rows[dong].Cells[0].Value.ToString();
                if (dgv_ChiTietHoaDon.Rows[dong].Cells[1].Value.ToString().Substring(0, 2) == "TH") cbo_Loai.SelectedIndex = 0;
                else cbo_Loai.SelectedIndex = 1;
                cbo_MaL.SelectedValue = dgv_ChiTietHoaDon.Rows[dong].Cells[1].Value.ToString();
                txt_name.Text = dgv_ChiTietHoaDon.Rows[dong].Cells[2].Value.ToString();
                txt_SL.Text = dgv_ChiTietHoaDon.Rows[dong].Cells[3].Value.ToString();
                txt_ThanhTien.Text = dgv_ChiTietHoaDon.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void GUI_CHITIET_HOADON_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void cbo_MaL_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Loai.SelectedIndex == 0)
                {
                    txt_name.Text = BUS_Thuoc.LayTenThuoc(cbo_MaL.SelectedValue.ToString());
                }
                else
                {
                    txt_name.Text = BUS_DichVu.LayTenDichVu(cbo_MaL.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

       

        private void dgv_ChiTietHoaDon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                et_ct.MaHD = cbo_MaHD.SelectedValue.ToString();
                et_ct.MaLoai = cbo_MaL.SelectedValue.ToString();
                et_ct.TenLoai = txt_name.Text;
                et_ct.Sl = Convert.ToInt32(txt_SL.Text);
                int dong = dgv_ChiTietHoaDon.CurrentCell.RowIndex;
                if (dgv_ChiTietHoaDon.Rows[dong].Cells[1].Value.ToString().Substring(0, 2) == "TH")
                {

                    dgv_ChiTietHoaDon.DataSource = BUS_MuaThuoc.LayDuLieuBangMa(dgv_ChiTietHoaDon.Rows[dong].Cells[0].Value.ToString());

                }
                else
                {
                    dgv_ChiTietHoaDon.DataSource = BUS_SuDungDV.LayDuLieuBangMa(dgv_ChiTietHoaDon.Rows[dong].Cells[0].Value.ToString());

                }
                btn_Them.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            GUI_HoaDon hd = new GUI_HoaDon();
            hd.ShowDialog();
        }

        private void cbo_BacSi_SelectedValueChanged(object sender, EventArgs e)
        {
            try { lb_MaBS.Text = cbo_BacSi.SelectedValue.ToString(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void txt_SL_Leave(object sender, EventArgs e)
        {
            try
            {
                Control ctr = (Control)sender;
                if (ctr.Text.Trim().Length != 0) this.errorProvider1.Clear();
                else this.errorProvider1.SetError(ctr, "Vui lòng nhập số lượng");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control ctr = (Control)sender;
                if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1)) this.errorProvider1.SetError(ctr, "SL là số !");
                else this.errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void txt_Key_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên bệnh nhân cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập tên bệnh nhân cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ChiTietHoaDon.DataSource = bus_ct.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }
    }
}
