using DoAnLTUD_QLBV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_QLBV
{
    public partial class frm_main : Form
    {
      
        ChildrenForm child = new ChildrenForm();
     
       

       
        public frm_main()
        {
            InitializeComponent();
        }
        private void quảnLýBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BenhAn(), pnl_main);
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BenhNhan(), pnl_main);
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_DichVu(), pnl_main);
        }

        private void mànHìnhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (child.CurrentForm != null)
            {
                child.CurrentForm.Close();
            }
        }

      

        private void quảnLýHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_HoaDon(), pnl_main);
        }

       
        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_Khoa(), pnl_main);
        }

        private void quảnLýKhoaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_NhanVien(), pnl_main);
        }

       

       

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu xảy ra lỗi gì xin bạn hãy liên hệ với email của chúng tôi Teamwork@gmail.com", "Thông báo");
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_InDanhSachThongTinBenhNhan(), pnl_main);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_NhanVien(), pnl_main);
        }

        private void quảnLýPhòngĐiềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_PhongDieuTri(), pnl_main);
        }

        private void quảnLýPhòngKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_PhongKham(), pnl_main);
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_Thuoc(), pnl_main);
        }

        private void quảnLýChiTiếtHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_CHITIET_HOADON(), pnl_main);
        }

        private void quảnLýBệnhNhânTrongPhòngĐiềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BenhNhan_PhongDieuTri(), pnl_main);
        }

        private void quảnLýBệnhNhânĐiKhámBệnhTrongKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BenhNhan_PhongKham(),pnl_main);
        }

        private void danhSáchBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_INDanhSachBacSi(),pnl_main);
        }
    }
    
   
    
}
