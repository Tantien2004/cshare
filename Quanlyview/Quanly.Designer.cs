namespace Quanlyview
{
    partial class Quanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanly));
            btThoat = new Button();
            btDangXuat = new Button();
            dgvEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMaSV = new TextBox();
            tbTenSV = new TextBox();
            ckGioiTinh = new CheckBox();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            label5 = new Label();
            tbNoiSinh = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbKhoaHoc = new ComboBox();
            tbMaLopHoc = new TextBox();
            pbEmployeeImage = new PictureBox();
            btSelectImage = new Button();
            NgaySinh = new DateTimePicker();
            Sodienthoai = new Label();
            tbPhone = new TextBox();
            label9 = new Label();
            tbEmail = new TextBox();
            lbTimKiem = new Label();
            tbTimkiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).BeginInit();
            SuspendLayout();
            // 
            // btThoat
            // 
            btThoat.Location = new Point(586, 641);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(54, 32);
            btThoat.TabIndex = 0;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btDangXuat
            // 
            btDangXuat.Location = new Point(455, 641);
            btDangXuat.Margin = new Padding(3, 4, 3, 4);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(91, 32);
            btDangXuat.TabIndex = 1;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = true;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(14, 108);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(901, 196);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 316);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 361);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Họ và Tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 415);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Năm Sinh";
            // 
            // tbMaSV
            // 
            tbMaSV.Location = new Point(511, 312);
            tbMaSV.Margin = new Padding(3, 4, 3, 4);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.Size = new Size(166, 27);
            tbMaSV.TabIndex = 6;
            tbMaSV.TextChanged += tbId_TextChanged;
            // 
            // tbTenSV
            // 
            tbTenSV.Location = new Point(507, 361);
            tbTenSV.Margin = new Padding(3, 4, 3, 4);
            tbTenSV.Name = "tbTenSV";
            tbTenSV.Size = new Size(166, 27);
            tbTenSV.TabIndex = 8;
            // 
            // ckGioiTinh
            // 
            ckGioiTinh.AutoSize = true;
            ckGioiTinh.Checked = true;
            ckGioiTinh.CheckState = CheckState.Checked;
            ckGioiTinh.Location = new Point(507, 467);
            ckGioiTinh.Margin = new Padding(3, 4, 3, 4);
            ckGioiTinh.Name = "ckGioiTinh";
            ckGioiTinh.Size = new Size(63, 24);
            ckGioiTinh.TabIndex = 9;
            ckGioiTinh.Text = "Nam";
            ckGioiTinh.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(23, 55);
            btAddNew.Margin = new Padding(3, 4, 3, 4);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(56, 40);
            btAddNew.TabIndex = 10;
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(250, 55);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(56, 40);
            btEdit.TabIndex = 11;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(127, 55);
            btDelete.Margin = new Padding(3, 4, 3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(56, 40);
            btDelete.TabIndex = 12;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(250, 5);
            label5.Name = "label5";
            label5.Size = new Size(210, 35);
            label5.TabIndex = 13;
            label5.Text = "Quản lý Sinh Viên";
            label5.Click += label5_Click;
            // 
            // tbNoiSinh
            // 
            tbNoiSinh.Location = new Point(127, 316);
            tbNoiSinh.Margin = new Padding(3, 4, 3, 4);
            tbNoiSinh.Name = "tbNoiSinh";
            tbNoiSinh.Size = new Size(239, 27);
            tbNoiSinh.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 421);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 17;
            label6.Text = "Mã Lớp Học";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 372);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 18;
            label7.Text = "Khoa Học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 320);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 19;
            label8.Text = "Nơi Sinh";
            // 
            // cbKhoaHoc
            // 
            cbKhoaHoc.FormattingEnabled = true;
            cbKhoaHoc.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Quản Trị Kinh Doanh", "Điện Công Nghiệp", "Điện Lạnh" });
            cbKhoaHoc.Location = new Point(127, 361);
            cbKhoaHoc.Margin = new Padding(3, 4, 3, 4);
            cbKhoaHoc.Name = "cbKhoaHoc";
            cbKhoaHoc.Size = new Size(239, 28);
            cbKhoaHoc.TabIndex = 20;
            cbKhoaHoc.SelectedIndexChanged += cbMaphongban_SelectedIndexChanged;
            // 
            // tbMaLopHoc
            // 
            tbMaLopHoc.Location = new Point(127, 417);
            tbMaLopHoc.Margin = new Padding(3, 4, 3, 4);
            tbMaLopHoc.Name = "tbMaLopHoc";
            tbMaLopHoc.Size = new Size(239, 27);
            tbMaLopHoc.TabIndex = 21;
            tbMaLopHoc.TextChanged += tbMaduan_TextChanged;
            // 
            // pbEmployeeImage
            // 
            pbEmployeeImage.Location = new Point(174, 543);
            pbEmployeeImage.Margin = new Padding(3, 4, 3, 4);
            pbEmployeeImage.Name = "pbEmployeeImage";
            pbEmployeeImage.Size = new Size(90, 107);
            pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployeeImage.TabIndex = 22;
            pbEmployeeImage.TabStop = false;
            // 
            // btSelectImage
            // 
            btSelectImage.Location = new Point(74, 484);
            btSelectImage.Margin = new Padding(3, 4, 3, 4);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(109, 33);
            btSelectImage.TabIndex = 23;
            btSelectImage.Text = "Chọn ảnh...";
            btSelectImage.UseVisualStyleBackColor = true;
            btSelectImage.Click += btSelectImage_Click;
            // 
            // NgaySinh
            // 
            NgaySinh.Location = new Point(507, 407);
            NgaySinh.Margin = new Padding(3, 4, 3, 4);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new Size(166, 27);
            NgaySinh.TabIndex = 24;
            NgaySinh.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Sodienthoai
            // 
            Sodienthoai.AutoSize = true;
            Sodienthoai.Location = new Point(414, 505);
            Sodienthoai.Name = "Sodienthoai";
            Sodienthoai.Size = new Size(102, 20);
            Sodienthoai.TabIndex = 25;
            Sodienthoai.Text = "Số Điện Thoại";
            Sodienthoai.Click += label4_Click;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(511, 505);
            tbPhone.Margin = new Padding(3, 4, 3, 4);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(163, 27);
            tbPhone.TabIndex = 26;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 560);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 27;
            label9.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(511, 556);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(163, 27);
            tbEmail.TabIndex = 28;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // lbTimKiem
            // 
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(388, 55);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 29;
            lbTimKiem.Text = "Tim kiem";
            // 
            // tbTimkiem
            // 
            tbTimkiem.Location = new Point(477, 52);
            tbTimkiem.Name = "tbTimkiem";
            tbTimkiem.Size = new Size(200, 27);
            tbTimkiem.TabIndex = 30;
            tbTimkiem.TextChanged += tbTimkiem_TextChanged;
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(945, 689);
            Controls.Add(tbTimkiem);
            Controls.Add(lbTimKiem);
            Controls.Add(tbEmail);
            Controls.Add(label9);
            Controls.Add(tbPhone);
            Controls.Add(Sodienthoai);
            Controls.Add(NgaySinh);
            Controls.Add(btSelectImage);
            Controls.Add(pbEmployeeImage);
            Controls.Add(tbMaLopHoc);
            Controls.Add(cbKhoaHoc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbNoiSinh);
            Controls.Add(label5);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btAddNew);
            Controls.Add(ckGioiTinh);
            Controls.Add(tbTenSV);
            Controls.Add(tbMaSV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Controls.Add(btDangXuat);
            Controls.Add(btThoat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Quanly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quanly";
            FormClosed += Quanly_FormClosed;
            Load += Quanly_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btThoat;
        private Button btDangXuat;
        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbMaSV;
        private TextBox tbTenSV;
        private CheckBox ckGioiTinh;
        private Button btAddNew;
        private Button btEdit;
        private Button btDelete;
        private Label label5;
        private TextBox tbNoiSinh;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbKhoaHoc;
        private TextBox tbMaLopHoc;
        private PictureBox pbEmployeeImage;
        private Button btSelectImage;
        private DateTimePicker NgaySinh;
        private Label Sodienthoai;
        private TextBox tbPhone;
        private Label label9;
        private TextBox tbEmail;
        private Label lbTimKiem;
        private TextBox tbTimkiem;
    }
}