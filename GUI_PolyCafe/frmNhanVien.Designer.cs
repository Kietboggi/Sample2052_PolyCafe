namespace GUI_PolyCafe
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtHoTen = new TextBox();
            txtMaNhanVien = new TextBox();
            comboBox5 = new ComboBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtMatKhau = new TextBox();
            comboBox4 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            radioButton2 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dgvnhanvien = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnMoi = new Button();
            txtXacNhanMatKhau = new TextBox();
            rdoNhanVien = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(rdoNhanVien);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(117, 31);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(151, 27);
            txtHoTen.TabIndex = 17;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(117, 81);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(151, 27);
            txtMaNhanVien.TabIndex = 16;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(869, 80);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(151, 28);
            comboBox5.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(788, 88);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 14;
            label9.Text = "Trạng thái";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(370, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 27);
            txtEmail.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(295, 39);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 12;
            label8.Text = "Email:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(615, 80);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(151, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(615, 31);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(540, 88);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 10;
            label7.Text = "Mật khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(540, 39);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 9;
            label6.Text = "Ca làm:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(370, 80);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(289, 88);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 7;
            label5.Text = "Vai trò:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(862, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(788, 34);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(14, 88);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ tên:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(896, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(618, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 3;
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.BorderStyle = BorderStyle.Fixed3D;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Location = new Point(3, 222);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.Size = new Size(1020, 304);
            dgvnhanvien.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 187);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(136, 187);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(259, 187);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMoi
            // 
            btnMoi.Location = new Point(389, 187);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(105, 29);
            btnMoi.TabIndex = 8;
            btnMoi.Text = "Làm mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(628, 187);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(151, 27);
            txtXacNhanMatKhau.TabIndex = 18;
            // 
            // rdoNhanVien
            // 
            rdoNhanVien.AutoSize = true;
            rdoNhanVien.BackColor = Color.Transparent;
            rdoNhanVien.Location = new Point(862, 17);
            rdoNhanVien.Name = "rdoNhanVien";
            rdoNhanVien.Size = new Size(62, 24);
            rdoNhanVien.TabIndex = 18;
            rdoNhanVien.TabStop = true;
            rdoNhanVien.Text = "Nam";
            rdoNhanVien.UseVisualStyleBackColor = false;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1041, 538);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(btnMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvnhanvien);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private RadioButton radioButton2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dgvnhanvien;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtMatKhau;
        private ComboBox comboBox4;
        private Label label7;
        private Label label6;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboBox5;
        private Label label9;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnMoi;
        private TextBox txtHoTen;
        private TextBox txtMaNhanVien;
        private TextBox txtXacNhanMatKhau;
        private RadioButton rdoNhanVien;
    }
}