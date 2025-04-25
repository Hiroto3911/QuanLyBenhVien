namespace DoAnLTUD_QLBV
{
    partial class GUI_BenhNhan_PhongDieuTri
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayXuat = new System.Windows.Forms.DateTimePicker();
            this.cbo_BenhNhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_BN_PDT = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbo_PDT = new System.Windows.Forms.ComboBox();
            this.lb_nameBN = new System.Windows.Forms.Label();
            this.cbo_locPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BN_PDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 146;
            this.label5.Text = "Ngày Nhập Viện :";
            // 
            // dtp_NgayXuat
            // 
            this.dtp_NgayXuat.Location = new System.Drawing.Point(598, 109);
            this.dtp_NgayXuat.Name = "dtp_NgayXuat";
            this.dtp_NgayXuat.Size = new System.Drawing.Size(191, 20);
            this.dtp_NgayXuat.TabIndex = 145;
            // 
            // cbo_BenhNhan
            // 
            this.cbo_BenhNhan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_BenhNhan.FormattingEnabled = true;
            this.cbo_BenhNhan.Location = new System.Drawing.Point(263, 108);
            this.cbo_BenhNhan.Name = "cbo_BenhNhan";
            this.cbo_BenhNhan.Size = new System.Drawing.Size(191, 21);
            this.cbo_BenhNhan.TabIndex = 144;
            this.cbo_BenhNhan.SelectedValueChanged += new System.EventHandler(this.cbo_BenhNhan_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 143;
            this.label4.Text = "Ngày Xuất Viện :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 139;
            this.label3.Text = "Mã Bệnh Nhân :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "Mã  Phòng Điều Trị  :";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(767, 489);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 136;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(442, 489);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 35);
            this.btn_LamMoi.TabIndex = 133;
            this.btn_LamMoi.Text = "Làm mới ";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(330, 489);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 35);
            this.btn_Sua.TabIndex = 132;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(214, 489);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 131;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(97, 489);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 35);
            this.btn_Them.TabIndex = 130;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_BN_PDT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 257);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bệnh Nhân Có Trong Phòng Điều Trị";
            // 
            // dgv_BN_PDT
            // 
            this.dgv_BN_PDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BN_PDT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_BN_PDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BN_PDT.Location = new System.Drawing.Point(22, 21);
            this.dgv_BN_PDT.Name = "dgv_BN_PDT";
            this.dgv_BN_PDT.Size = new System.Drawing.Size(808, 221);
            this.dgv_BN_PDT.TabIndex = 0;
            this.dgv_BN_PDT.Click += new System.EventHandler(this.dgv_BN_PDT_Click);
            this.dgv_BN_PDT.DoubleClick += new System.EventHandler(this.dgv_BN_PDT_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(840, 37);
            this.label7.TabIndex = 128;
            this.label7.Text = "THÔNG TIN BỆNH NHÂN TRONG PHÒNG ĐIỀU TRỊ ";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Location = new System.Drawing.Point(593, 61);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(191, 20);
            this.dtp_NgayNhap.TabIndex = 147;
            // 
            // cbo_PDT
            // 
            this.cbo_PDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_PDT.FormattingEnabled = true;
            this.cbo_PDT.Location = new System.Drawing.Point(260, 61);
            this.cbo_PDT.Name = "cbo_PDT";
            this.cbo_PDT.Size = new System.Drawing.Size(191, 21);
            this.cbo_PDT.TabIndex = 148;
            // 
            // lb_nameBN
            // 
            this.lb_nameBN.AutoSize = true;
            this.lb_nameBN.BackColor = System.Drawing.Color.Transparent;
            this.lb_nameBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameBN.Location = new System.Drawing.Point(260, 142);
            this.lb_nameBN.Name = "lb_nameBN";
            this.lb_nameBN.Size = new System.Drawing.Size(106, 16);
            this.lb_nameBN.TabIndex = 149;
            this.lb_nameBN.Text = "Tên Bệnh Nhân :";
            // 
            // cbo_locPhong
            // 
            this.cbo_locPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_locPhong.FormattingEnabled = true;
            this.cbo_locPhong.Location = new System.Drawing.Point(718, 451);
            this.cbo_locPhong.Name = "cbo_locPhong";
            this.cbo_locPhong.Size = new System.Drawing.Size(124, 21);
            this.cbo_locPhong.TabIndex = 150;
            this.cbo_locPhong.SelectedValueChanged += new System.EventHandler(this.cbo_locPhong_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 151;
            this.label1.Text = "Lọc Theo Phòng";
            // 
            // GUI_BenhNhan_PhongDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTUD_QLBV.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_locPhong);
            this.Controls.Add(this.lb_nameBN);
            this.Controls.Add(this.cbo_PDT);
            this.Controls.Add(this.dtp_NgayNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_NgayXuat);
            this.Controls.Add(this.cbo_BenhNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Name = "GUI_BenhNhan_PhongDieuTri";
            this.Text = "GUI_BenhNhan_PhongDieuTri";
            this.Load += new System.EventHandler(this.GUI_BenhNhan_PhongDieuTri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BN_PDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_NgayXuat;
        private System.Windows.Forms.ComboBox cbo_BenhNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_BN_PDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.ComboBox cbo_PDT;
        private System.Windows.Forms.Label lb_nameBN;
        private System.Windows.Forms.ComboBox cbo_locPhong;
        private System.Windows.Forms.Label label1;
    }
}