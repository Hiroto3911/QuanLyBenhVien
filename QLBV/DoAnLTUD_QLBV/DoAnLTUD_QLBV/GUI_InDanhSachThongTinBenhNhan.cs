using BUS_QLBV;
using CrystalDecisions.Shared;
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
    public partial class GUI_InDanhSachThongTinBenhNhan : Form
    {
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        public GUI_InDanhSachThongTinBenhNhan()
        {
            InitializeComponent();
        }

        private void cbo_BenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            // khởi tạo report 
            crt_ThongTinBenhNhan rp = new crt_ThongTinBenhNhan();
            // khởi tạo giá trị 
            ParameterValues para = new ParameterValues();   
            // khai báo giá trị 
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue(); 
            // gán giá trị 
            paraValue.Value = cbo_BenhNhan.SelectedValue.ToString();
            // thêm giá trị cho biến 
            para.Add(paraValue);
            // gán giá trị cho crystal report 
            rp.DataDefinition.ParameterFields["@MABN"].ApplyCurrentValues(para);
            // gán lại giá trị cho source
            crystalReportViewer1.ReportSource = rp; 
        }

        private void GUI_InDanhSachThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            cbo_BenhNhan.DataSource = BUS_BenhNhan.getData();
            cbo_BenhNhan.ValueMember = "MABN";
            cbo_BenhNhan.DisplayMember = "MABN";
        }
    }
}
