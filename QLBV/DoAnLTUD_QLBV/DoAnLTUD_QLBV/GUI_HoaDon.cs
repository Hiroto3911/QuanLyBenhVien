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
    public partial class GUI_HoaDon : Form
    {
        BUS_BenhNhan bus_BenhNhan = new BUS_BenhNhan();
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        ET_HoaDon eT_HoaDon = new ET_HoaDon();

        public GUI_HoaDon()
        {
            InitializeComponent();
        }

        private void GUI_HoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                cbo_BenhNhan.DataSource = bus_BenhNhan.getData();
                cbo_BenhNhan.ValueMember = "MABN";
                cbo_BenhNhan.DisplayMember = "MABN";
                dgv_HoaDon.DataSource = bus_HoaDon.getDataFromHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            eT_HoaDon.MaHD = txt_ID.Text;
            eT_HoaDon.MaBenhNhan = cbo_BenhNhan.SelectedValue.ToString();
            eT_HoaDon.NgayLapHB = Convert.ToDateTime(dtp_NgayLap.Text);
            eT_HoaDon.TongTien = 0; 
            try
            {
                if(bus_HoaDon.ThemHoaDon(eT_HoaDon)== true)
                {
                    MessageBox.Show($"THÊM THÀNH CÔNG ", "Thông báo");
                    dgv_HoaDon.DataSource = bus_HoaDon.getDataFromHoaDon();
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
            eT_HoaDon.MaHD = txt_ID.Text;
            eT_HoaDon.MaBenhNhan = cbo_BenhNhan.SelectedValue.ToString();
            eT_HoaDon.NgayLapHB = Convert.ToDateTime(dtp_NgayLap.Text);
            eT_HoaDon.TongTien = (Convert.ToDouble(txt_ThanhTien.Text)>0.0) ? Convert.ToDouble(txt_ThanhTien.Text):0;
            try
            {
                if (bus_HoaDon.XoaHoaDon(eT_HoaDon) == true)
                {
                    MessageBox.Show($"XOÁ THÀNH CÔNG ", "Thông báo");
                    dgv_HoaDon.DataSource = bus_HoaDon.getDataFromHoaDon();
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
            eT_HoaDon.MaHD = txt_ID.Text;
            eT_HoaDon.MaBenhNhan = cbo_BenhNhan.SelectedValue.ToString();
            eT_HoaDon.NgayLapHB = Convert.ToDateTime(dtp_NgayLap.Text);
            eT_HoaDon.TongTien = (Convert.ToDouble(txt_ThanhTien.Text) > 0.0) ? Convert.ToDouble(txt_ThanhTien.Text) : 0;
            try
            {
                if (bus_HoaDon.SuaHoaDon(eT_HoaDon) == true)
                {
                    MessageBox.Show($"SỬA THÀNH CÔNG ", "Thông báo");
                    dgv_HoaDon.DataSource = bus_HoaDon.getDataFromHoaDon();
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
            txt_ID.Clear();
            cbo_BenhNhan.SelectedValue = "BN0001";
            txt_name.Clear();
            dtp_NgayLap.Text = DateTime.Now.ToString();
            txt_ThanhTien.Clear();
            txt_ID.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
               dgv_HoaDon.DataSource = bus_HoaDon.FindData(txt_Key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void dgv_HoaDon_Click(object sender, EventArgs e)
        {
            int dong = dgv_HoaDon.CurrentCell.RowIndex;
            txt_ID.Text = dgv_HoaDon.Rows[dong].Cells[0].Value.ToString();
            cbo_BenhNhan.SelectedValue = dgv_HoaDon.Rows[dong].Cells[1].Value.ToString();
            txt_name.Text = bus_BenhNhan.LayHoTenBN(dgv_HoaDon.Rows[dong].Cells[1].Value.ToString());
            dtp_NgayLap.Text = dgv_HoaDon.Rows[dong].Cells[2].Value.ToString();
            txt_ThanhTien.Text = dgv_HoaDon.Rows[dong].Cells[3].Value.ToString();
        }

        private void GUI_HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
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

        private void cbo_BenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {

            txt_name.Text = bus_BenhNhan.LayHoTenBN(cbo_BenhNhan.SelectedValue.ToString());
        }
    }
}
