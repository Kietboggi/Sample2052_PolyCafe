namespace GUI_PolyCafe
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            groupBox1 = new GroupBox();
            txtTenSanPham = new TextBox();
            label6 = new Label();
            btnMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnChonAnh = new Button();
            ptHinhAnh = new PictureBox();
            rbtNgung = new RadioButton();
            rdtHoatDong = new RadioButton();
            label4 = new Label();
            cbLoaiSanPham = new ComboBox();
            label3 = new Label();
            txtDonGia = new MaskedTextBox();
            label2 = new Label();
            txtMaSanPham = new TextBox();
            label1 = new Label();
            dgvDanhSachSanPham = new DataGridView();
            label5 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(ptHinhAnh);
            groupBox1.Controls.Add(rbtNgung);
            groupBox1.Controls.Add(rdtHoatDong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbLoaiSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 570);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(122, 88);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(162, 27);
            txtTenSanPham.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(11, 95);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 15;
            label6.Text = "Tên Sản Phẩm";
            // 
            // btnMoi
            // 
            btnMoi.BackColor = Color.WhiteSmoke;
            btnMoi.ForeColor = Color.FromArgb(255, 128, 0);
            btnMoi.Location = new Point(152, 518);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(110, 46);
            btnMoi.TabIndex = 14;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.WhiteSmoke;
            btnXoa.ForeColor = Color.Blue;
            btnXoa.Location = new Point(11, 518);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 46);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.WhiteSmoke;
            btnSua.ForeColor = Color.FromArgb(0, 192, 192);
            btnSua.Location = new Point(152, 453);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 46);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.WhiteSmoke;
            btnThem.ForeColor = Color.Red;
            btnThem.Location = new Point(11, 454);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 46);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.White;
            btnChonAnh.Location = new Point(95, 418);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 10;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            // 
            // ptHinhAnh
            // 
            ptHinhAnh.Location = new Point(32, 272);
            ptHinhAnh.Name = "ptHinhAnh";
            ptHinhAnh.Size = new Size(230, 140);
            ptHinhAnh.TabIndex = 9;
            ptHinhAnh.TabStop = false;
            // 
            // rbtNgung
            // 
            rbtNgung.AutoSize = true;
            rbtNgung.Location = new Point(122, 242);
            rbtNgung.Name = "rbtNgung";
            rbtNgung.Size = new Size(105, 24);
            rbtNgung.TabIndex = 8;
            rbtNgung.TabStop = true;
            rbtNgung.Text = "Ngừng bán";
            rbtNgung.UseVisualStyleBackColor = true;
            // 
            // rdtHoatDong
            // 
            rdtHoatDong.AutoSize = true;
            rdtHoatDong.Location = new Point(122, 212);
            rdtHoatDong.Name = "rdtHoatDong";
            rdtHoatDong.Size = new Size(102, 24);
            rdtHoatDong.TabIndex = 7;
            rdtHoatDong.TabStop = true;
            rdtHoatDong.Text = "Hoạt động";
            rdtHoatDong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(11, 223);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 6;
            label4.Text = "Trạng Thái";
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(122, 172);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(162, 28);
            cbLoaiSanPham.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(11, 180);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Loại Sản Phẩm";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(122, 132);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(162, 27);
            txtDonGia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(11, 139);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Đơn Giá";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(122, 42);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(162, 27);
            txtMaSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(11, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm";
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Location = new Point(325, 75);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dgvDanhSachSanPham.Size = new Size(813, 515);
            dgvDanhSachSanPham.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Italic | FontStyle.Underline);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(454, 22);
            label5.Name = "label5";
            label5.Size = new Size(148, 37);
            label5.TabIndex = 2;
            label5.Text = "SẢN PHẨM";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(797, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(253, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1072, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(35, 27);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1141, 594);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label5);
            Controls.Add(dgvDanhSachSanPham);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private MaskedTextBox txtDonGia;
        private Label label2;
        private TextBox txtMaSanPham;
        private RadioButton rbtNgung;
        private RadioButton rdtHoatDong;
        private Label label4;
        private ComboBox cbLoaiSanPham;
        private Button btnChonAnh;
        private PictureBox ptHinhAnh;
        private Button btnMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvDanhSachSanPham;
        private Label label5;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private TextBox txtTenSanPham;
        private Label label6;
    }
}