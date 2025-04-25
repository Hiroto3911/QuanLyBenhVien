namespace GUI_QLBV
{
    partial class GUI_NhanVien
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
            this.dtp_NgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_ChucVu = new System.Windows.Forms.ComboBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_vaitro = new System.Windows.Forms.ComboBox();
            this.cbo_khoa = new System.Windows.Forms.ComboBox();
            this.bnt_Thoat = new System.Windows.Forms.Button();
            this.btn_S = new System.Windows.Forms.Button();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_t = new System.Windows.Forms.Button();
            this.cb_phai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnlm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_NgayLamViec
            // 
            this.dtp_NgayLamViec.Location = new System.Drawing.Point(647, 167);
            this.dtp_NgayLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayLamViec.Name = "dtp_NgayLamViec";
            this.dtp_NgayLamViec.Size = new System.Drawing.Size(187, 20);
            this.dtp_NgayLamViec.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(513, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ngày làm việc :";
            this.label9.UseWaitCursor = true;
            // 
            // txt_DC
            // 
            this.txt_DC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_DC.Location = new System.Drawing.Point(215, 167);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(191, 20);
            this.txt_DC.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(125, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Địa chỉ  :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_NhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 166);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(15, 19);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 62;
            this.dgv_NhanVien.Size = new System.Drawing.Size(883, 131);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.Click += new System.EventHandler(this.dgv_NhanVien_Click);
            this.dgv_NhanVien.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.dgv_NhanVien_ChangeUICues);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(306, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "Thông Tin Nhân viên";
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_ChucVu.FormattingEnabled = true;
            this.cbo_ChucVu.Items.AddRange(new object[] {
            "Bác Sĩ Hạng 1",
            "Bác Sĩ Hạng 2 ",
            "Bác Sĩ Hạng 3",
            "Thực Tập ",
            "Bảo Vệ",
            "Thu Ngân",
            "Tạp Vụ",
            "Điều Dưỡng"});
            this.cbo_ChucVu.Location = new System.Drawing.Point(647, 102);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(185, 21);
            this.cbo_ChucVu.TabIndex = 62;
            // 
            // txt_Ten
            // 
            this.txt_Ten.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Ten.Location = new System.Drawing.Point(215, 134);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(191, 20);
            this.txt_Ten.TabIndex = 61;
            // 
            // txt_Ho
            // 
            this.txt_Ho.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Ho.Location = new System.Drawing.Point(215, 99);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(191, 20);
            this.txt_Ho.TabIndex = 60;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ID.Location = new System.Drawing.Point(215, 66);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(191, 20);
            this.txt_ID.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(108, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Ngày sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(556, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Chức vụ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(151, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Họ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(158, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 53;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(957, 682);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 86;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(461, 687);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 35);
            this.btn_LamMoi.TabIndex = 83;
            this.btn_LamMoi.Text = "Làm mới ";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(349, 687);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 35);
            this.btn_Sua.TabIndex = 82;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(233, 687);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 81;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(116, 687);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 35);
            this.btn_Them.TabIndex = 80;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txt_Key
            // 
            this.txt_Key.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Key.Location = new System.Drawing.Point(633, 423);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(192, 20);
            this.txt_Key.TabIndex = 85;
            this.txt_Key.Text = "Nhập tên nhân viên cần tìm";
            this.txt_Key.Enter += new System.EventHandler(this.txt_Key_Enter);
            this.txt_Key.Leave += new System.EventHandler(this.txt_Key_Leave);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(838, 420);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 84;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(577, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 89;
            this.label12.Text = "Khoa :";
            this.label12.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(566, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 90;
            this.label13.Text = "Vai trò :";
            this.label13.UseWaitCursor = true;
            // 
            // cbo_vaitro
            // 
            this.cbo_vaitro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_vaitro.FormattingEnabled = true;
            this.cbo_vaitro.Items.AddRange(new object[] {
            "Nhân Viên",
            "Bác Sĩ"});
            this.cbo_vaitro.Location = new System.Drawing.Point(647, 133);
            this.cbo_vaitro.Name = "cbo_vaitro";
            this.cbo_vaitro.Size = new System.Drawing.Size(185, 21);
            this.cbo_vaitro.TabIndex = 92;
            // 
            // cbo_khoa
            // 
            this.cbo_khoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_khoa.FormattingEnabled = true;
            this.cbo_khoa.Items.AddRange(new object[] {
            "KHOA NỘI",
            "KHOA NGOẠI",
            "KHOA NỘI TIM MẠCH",
            "KHOA NỘI TIÊU HÓA",
            "KHOA PHỤ SẢN"});
            this.cbo_khoa.Location = new System.Drawing.Point(647, 199);
            this.cbo_khoa.Name = "cbo_khoa";
            this.cbo_khoa.Size = new System.Drawing.Size(185, 21);
            this.cbo_khoa.TabIndex = 93;
            // 
            // bnt_Thoat
            // 
            this.bnt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Thoat.Location = new System.Drawing.Point(838, 464);
            this.bnt_Thoat.Name = "bnt_Thoat";
            this.bnt_Thoat.Size = new System.Drawing.Size(75, 35);
            this.bnt_Thoat.TabIndex = 101;
            this.bnt_Thoat.Text = "Thoát";
            this.bnt_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_S
            // 
            this.btn_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_S.Location = new System.Drawing.Point(260, 464);
            this.btn_S.Name = "btn_S";
            this.btn_S.Size = new System.Drawing.Size(75, 35);
            this.btn_S.TabIndex = 99;
            this.btn_S.Text = "Sửa";
            this.btn_S.UseVisualStyleBackColor = true;
            this.btn_S.Click += new System.EventHandler(this.btn_S_Click);
            // 
            // btn_X
            // 
            this.btn_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.Location = new System.Drawing.Point(144, 464);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(75, 35);
            this.btn_X.TabIndex = 98;
            this.btn_X.Text = "Xoá";
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_t
            // 
            this.btn_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t.Location = new System.Drawing.Point(27, 464);
            this.btn_t.Name = "btn_t";
            this.btn_t.Size = new System.Drawing.Size(76, 35);
            this.btn_t.TabIndex = 97;
            this.btn_t.Text = "Thêm ";
            this.btn_t.UseVisualStyleBackColor = true;
            this.btn_t.Click += new System.EventHandler(this.btn_t_Click);
            // 
            // cb_phai
            // 
            this.cb_phai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_phai.FormattingEnabled = true;
            this.cb_phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_phai.Location = new System.Drawing.Point(647, 66);
            this.cb_phai.Name = "cb_phai";
            this.cb_phai.Size = new System.Drawing.Size(185, 21);
            this.cb_phai.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(548, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 102;
            this.label10.Text = "Giới Tính :";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(215, 200);
            this.dtpngaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(191, 20);
            this.dtpngaysinh.TabIndex = 104;
            // 
            // btnlm
            // 
            this.btnlm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlm.Location = new System.Drawing.Point(363, 464);
            this.btnlm.Name = "btnlm";
            this.btnlm.Size = new System.Drawing.Size(75, 35);
            this.btnlm.TabIndex = 105;
            this.btnlm.Text = "Làm mới ";
            this.btnlm.UseVisualStyleBackColor = true;
            this.btnlm.Click += new System.EventHandler(this.btnlm_Click);
            // 
            // GUI_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTUD_QLBV.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 525);
            this.Controls.Add(this.btnlm);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.cb_phai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnt_Thoat);
            this.Controls.Add(this.btn_S);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_t);
            this.Controls.Add(this.cbo_khoa);
            this.Controls.Add(this.cbo_vaitro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dtp_NgayLamViec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_DC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_ChucVu);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Ho);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_NhanVien";
            this.Text = "GUI_NhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_NhanVien_FormClosing);
            this.Load += new System.EventHandler(this.GUI_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_NgayLamViec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_ChucVu;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_vaitro;
        private System.Windows.Forms.ComboBox cbo_khoa;
        private System.Windows.Forms.Button bnt_Thoat;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_t;
        private System.Windows.Forms.ComboBox cb_phai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.Button btnlm;
    }
}