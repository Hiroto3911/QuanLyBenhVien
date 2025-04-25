namespace DoAnLTUD_QLBV
{
    partial class GUI_CHITIET_HOADON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbo_MaL = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Loai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_MaHD = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.cbo_BacSi = new System.Windows.Forms.ComboBox();
            this.lb_BS = new System.Windows.Forms.Label();
            this.lb_MaBS = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_MaL
            // 
            this.cbo_MaL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_MaL.FormattingEnabled = true;
            this.cbo_MaL.Location = new System.Drawing.Point(147, 139);
            this.cbo_MaL.Name = "cbo_MaL";
            this.cbo_MaL.Size = new System.Drawing.Size(191, 21);
            this.cbo_MaL.TabIndex = 115;
            this.cbo_MaL.SelectedValueChanged += new System.EventHandler(this.cbo_MaL_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 111;
            this.label4.Text = "Tên loại :";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(711, 503);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 109;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(375, 503);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 35);
            this.btn_LamMoi.TabIndex = 106;
            this.btn_LamMoi.Text = "Làm mới ";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(263, 503);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 35);
            this.btn_Sua.TabIndex = 105;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(147, 503);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 104;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(30, 503);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 35);
            this.btn_Them.TabIndex = 103;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Key
            // 
            this.txt_Key.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Key.Location = new System.Drawing.Point(515, 474);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(192, 20);
            this.txt_Key.TabIndex = 108;
            this.txt_Key.Text = "Nhập tên bệnh nhân cần tìm";
            this.txt_Key.TextChanged += new System.EventHandler(this.txt_Key_TextChanged);
            this.txt_Key.Enter += new System.EventHandler(this.txt_Key_Enter);
            this.txt_Key.Leave += new System.EventHandler(this.txt_Key_Leave);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(713, 474);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 107;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(499, 139);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(208, 20);
            this.txt_ThanhTien.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_ChiTietHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 261);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết Hoá Đơn";
            // 
            // dgv_ChiTietHoaDon
            // 
            this.dgv_ChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHoaDon.Location = new System.Drawing.Point(20, 21);
            this.dgv_ChiTietHoaDon.Name = "dgv_ChiTietHoaDon";
            this.dgv_ChiTietHoaDon.Size = new System.Drawing.Size(718, 226);
            this.dgv_ChiTietHoaDon.TabIndex = 0;
            this.dgv_ChiTietHoaDon.Click += new System.EventHandler(this.dgv_ChiTietHoaDon_Click);
            this.dgv_ChiTietHoaDon.DoubleClick += new System.EventHandler(this.dgv_ChiTietHoaDon_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 37);
            this.label7.TabIndex = 100;
            this.label7.Text = "Thông Tin Chi Tiết Hoá Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = "Thành tiền  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Mã loại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Mã  hoá đơn  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 95;
            // 
            // txt_SL
            // 
            this.txt_SL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_SL.Location = new System.Drawing.Point(147, 168);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(191, 20);
            this.txt_SL.TabIndex = 118;
            this.txt_SL.TextChanged += new System.EventHandler(this.txt_SL_TextChanged);
            this.txt_SL.Leave += new System.EventHandler(this.txt_SL_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 117;
            this.label5.Text = "số lượng  :";
            // 
            // cbo_Loai
            // 
            this.cbo_Loai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_Loai.FormattingEnabled = true;
            this.cbo_Loai.Location = new System.Drawing.Point(147, 108);
            this.cbo_Loai.Name = "cbo_Loai";
            this.cbo_Loai.Size = new System.Drawing.Size(191, 21);
            this.cbo_Loai.TabIndex = 121;
            this.cbo_Loai.SelectedValueChanged += new System.EventHandler(this.cbo_Loai_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 120;
            this.label8.Text = "Loại :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 119;
            // 
            // cbo_MaHD
            // 
            this.cbo_MaHD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_MaHD.FormattingEnabled = true;
            this.cbo_MaHD.Location = new System.Drawing.Point(147, 74);
            this.cbo_MaHD.Name = "cbo_MaHD";
            this.cbo_MaHD.Size = new System.Drawing.Size(191, 21);
            this.cbo_MaHD.TabIndex = 123;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(499, 72);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(293, 57);
            this.txt_name.TabIndex = 124;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Location = new System.Drawing.Point(484, 503);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(75, 35);
            this.btn_HoaDon.TabIndex = 125;
            this.btn_HoaDon.Text = "Hoá Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // cbo_BacSi
            // 
            this.cbo_BacSi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_BacSi.FormattingEnabled = true;
            this.cbo_BacSi.Location = new System.Drawing.Point(499, 168);
            this.cbo_BacSi.Name = "cbo_BacSi";
            this.cbo_BacSi.Size = new System.Drawing.Size(212, 21);
            this.cbo_BacSi.TabIndex = 117;
            this.cbo_BacSi.Visible = false;
            this.cbo_BacSi.SelectedValueChanged += new System.EventHandler(this.cbo_BacSi_SelectedValueChanged);
            // 
            // lb_BS
            // 
            this.lb_BS.AutoSize = true;
            this.lb_BS.BackColor = System.Drawing.Color.Transparent;
            this.lb_BS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BS.Location = new System.Drawing.Point(434, 168);
            this.lb_BS.Name = "lb_BS";
            this.lb_BS.Size = new System.Drawing.Size(55, 16);
            this.lb_BS.TabIndex = 116;
            this.lb_BS.Text = "Bác sĩ  :";
            this.lb_BS.Visible = false;
            // 
            // lb_MaBS
            // 
            this.lb_MaBS.AutoSize = true;
            this.lb_MaBS.BackColor = System.Drawing.Color.Transparent;
            this.lb_MaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBS.Location = new System.Drawing.Point(717, 169);
            this.lb_MaBS.Name = "lb_MaBS";
            this.lb_MaBS.Size = new System.Drawing.Size(26, 16);
            this.lb_MaBS.TabIndex = 126;
            this.lb_MaBS.Text = "ID :";
            this.lb_MaBS.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GUI_CHITIET_HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTUD_QLBV.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 567);
            this.Controls.Add(this.lb_MaBS);
            this.Controls.Add(this.cbo_BacSi);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.lb_BS);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cbo_MaHD);
            this.Controls.Add(this.cbo_Loai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_MaL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CHITIET_HOADON";
            this.Text = "GUI_CHITIET_HOADON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_CHITIET_HOADON_FormClosing);
            this.Load += new System.EventHandler(this.GUI_CHITIET_HOADON_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_MaL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ChiTietHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Loai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_MaHD;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.ComboBox cbo_BacSi;
        private System.Windows.Forms.Label lb_BS;
        private System.Windows.Forms.Label lb_MaBS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}