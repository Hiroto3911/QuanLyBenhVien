using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS_QLBV;
using ET_QLBV;

namespace DoAnLTUD_QLBV
{
    public partial class GUI_BenhNhan_PhongDieuTri : Form
    {
        BUS_BenhNhan_PhongDieuTri BUS_BenhNhan_PhongDieuTri = new BUS_BenhNhan_PhongDieuTri();
        BUS_PhongDieuTri BUS_PhongDieuTri = new BUS_PhongDieuTri();
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        ET_BenhNhan_PhongDieuTri ET_BenhNhan_PhongDieuTri = new ET_BenhNhan_PhongDieuTri();
        public GUI_BenhNhan_PhongDieuTri()
        {
            InitializeComponent();
        }

        private void GUI_BenhNhan_PhongDieuTri_Load(object sender, EventArgs e)
        {
            try
            {
                cbo_BenhNhan.DataSource = BUS_BenhNhan.getData();
                cbo_BenhNhan.ValueMember = "MABN";
                cbo_BenhNhan.DisplayMember = "MABN";
                cbo_PDT.DataSource = BUS_PhongDieuTri.getDataFromPhongDieuTri();
                cbo_PDT.ValueMember = "MAPDT";
                cbo_PDT.DisplayMember = "MAPDT";
                cbo_locPhong.DataSource = BUS_PhongDieuTri.getDataFromPhongDieuTri();
                cbo_locPhong.ValueMember = "MAPDT";
                cbo_locPhong.DisplayMember = "MAPDT";
                dgv_BN_PDT.DataSource = BUS_BenhNhan_PhongDieuTri.getData();
                lb_nameBN.Text = BUS_BenhNhan.LayHoTenBN(cbo_BenhNhan.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_BenhNhan_PhongDieuTri.MaBN = cbo_BenhNhan.SelectedValue.ToString();
                ET_BenhNhan_PhongDieuTri.PgDT = cbo_PDT.SelectedValue.ToString();
                ET_BenhNhan_PhongDieuTri.NgayNhapVien = Convert.ToDateTime(dtp_NgayNhap.Text);

                if (BUS_BenhNhan_PhongDieuTri.ThemBenhNhan_PhongDieuTri(ET_BenhNhan_PhongDieuTri) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_BN_PDT.DataSource = BUS_BenhNhan_PhongDieuTri.getData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ET_BenhNhan_PhongDieuTri.MaBN = cbo_BenhNhan.SelectedValue.ToString();
                ET_BenhNhan_PhongDieuTri.PgDT = cbo_PDT.SelectedValue.ToString();
                ET_BenhNhan_PhongDieuTri.NgayNhapVien = Convert.ToDateTime(dtp_NgayNhap.Text);

                if (BUS_BenhNhan_PhongDieuTri.XoaBenhNhan_PhongDieuTri(ET_BenhNhan_PhongDieuTri) == false)
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_BN_PDT.DataSource = BUS_BenhNhan_PhongDieuTri.getData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_BenhNhan_PhongDieuTri.MaBN = cbo_BenhNhan.SelectedValue.ToString();
                ET_BenhNhan_PhongDieuTri.PgDT = cbo_PDT.SelectedValue.ToString();
                ET_BenhNhan_PhongDieuTri.NgayNhapVien = Convert.ToDateTime(dtp_NgayNhap.Text);
                ET_BenhNhan_PhongDieuTri.NgayXuatVien = Convert.ToDateTime(dtp_NgayXuat.Text);
                if (BUS_BenhNhan_PhongDieuTri.SuaBenhNhan(ET_BenhNhan_PhongDieuTri) == false)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_BN_PDT.DataSource = BUS_BenhNhan_PhongDieuTri.getData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            cbo_BenhNhan.SelectedIndex = 0;
            cbo_PDT.SelectedIndex = 0;
            dtp_NgayNhap.Text = DateTime.Now.ToString();
            dtp_NgayXuat.Text = DateTime.Now.ToString();
            dgv_BN_PDT.DataSource = BUS_BenhNhan_PhongDieuTri.getData();
            cbo_PDT.DataSource = BUS_PhongDieuTri.getDataFromPhongDieuTri();
            cbo_BenhNhan.DataSource = BUS_BenhNhan.getData();
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            cbo_locPhong.Enabled = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_BN_PDT_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_BN_PDT.CurrentCell.RowIndex;
                cbo_BenhNhan.SelectedValue = dgv_BN_PDT.Rows[dong].Cells[0].Value.ToString();
                cbo_PDT.SelectedValue = dgv_BN_PDT.Rows[dong].Cells[1].Value.ToString();
                dtp_NgayNhap.Text = dgv_BN_PDT.Rows[dong].Cells[2].Value.ToString();
                dtp_NgayXuat.Text = dgv_BN_PDT.Rows[dong].Cells[3].Value.ToString() == "" ? DateTime.Now.ToString() : dgv_BN_PDT.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }

        }

        private void cbo_BenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            try { lb_nameBN.Text = BUS_BenhNhan.LayHoTenBN(cbo_BenhNhan.SelectedValue.ToString()); }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void cbo_locPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_BN_PDT.DataSource = BUS_BenhNhan_PhongDieuTri.LocDSBangMaPhong(cbo_locPhong.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi :" + ex, "Thông báo");
            }
        }

        private void dgv_BN_PDT_DoubleClick(object sender, EventArgs e)
        {


            int dong = dgv_BN_PDT.CurrentCell.RowIndex;
            dgv_BN_PDT.DataSource = BUS_BenhNhan.ThongTinChiTietBN(dgv_BN_PDT.Rows[dong].Cells[0].Value.ToString());
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false; 
            btn_Xoa.Enabled = false;    
            cbo_locPhong.Enabled = false;

        }
    }
}
