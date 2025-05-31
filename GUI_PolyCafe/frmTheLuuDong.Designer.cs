namespace GUI_PolyCafe
{
    partial class frmTheLuuDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLuuDong));
            menuStrip1 = new MenuStrip();
            cậpToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaThe = new TextBox();
            txtChuSoHuu = new TextBox();
            cbTrangThai = new CheckBox();
            btnThem = new Button();
            btnMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgrDanhSachThe = new DataGridView();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachThe).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpToolStripMenuItem, dANHSÁCHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1051, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpToolStripMenuItem
            // 
            cậpToolStripMenuItem.Name = "cậpToolStripMenuItem";
            cậpToolStripMenuItem.Size = new Size(94, 24);
            cậpToolStripMenuItem.Text = "CẬP NHẬT";
            // 
            // dANHSÁCHToolStripMenuItem
            // 
            dANHSÁCHToolStripMenuItem.Name = "dANHSÁCHToolStripMenuItem";
            dANHSÁCHToolStripMenuItem.Size = new Size(108, 24);
            dANHSÁCHToolStripMenuItem.Text = "DANH SÁCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(420, 41);
            label2.Name = "label2";
            label2.Size = new Size(223, 40);
            label2.TabIndex = 2;
            label2.Text = "THẺ LƯU ĐỘNG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã thẻ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 4;
            label4.Text = "Chủ sở hữu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 5;
            label5.Text = "Trạng thái:";
            // 
            // txtMaThe
            // 
            txtMaThe.Location = new Point(95, 146);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.ReadOnly = true;
            txtMaThe.Size = new Size(183, 27);
            txtMaThe.TabIndex = 6;
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.Location = new Point(95, 188);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.Size = new Size(183, 27);
            txtChuSoHuu.TabIndex = 7;
            // 
            // cbTrangThai
            // 
            cbTrangThai.AutoSize = true;
            cbTrangThai.BackColor = Color.Transparent;
            cbTrangThai.Location = new Point(95, 241);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(103, 24);
            cbTrangThai.TabIndex = 8;
            cbTrangThai.Text = "Hoạt động";
            cbTrangThai.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackgroundImage = (Image)resources.GetObject("btnThem.BackgroundImage");
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(12, 288);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 40);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnMoi
            // 
            btnMoi.BackgroundImage = (Image)resources.GetObject("btnMoi.BackgroundImage");
            btnMoi.ForeColor = SystemColors.Highlight;
            btnMoi.Location = new Point(175, 347);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(127, 40);
            btnMoi.TabIndex = 10;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackgroundImage = (Image)resources.GetObject("btnSua.BackgroundImage");
            btnSua.ForeColor = Color.DarkOrange;
            btnSua.Location = new Point(175, 288);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(127, 40);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackgroundImage = (Image)resources.GetObject("btnXoa.BackgroundImage");
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(12, 347);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 40);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgrDanhSachThe
            // 
            dgrDanhSachThe.BackgroundColor = SystemColors.ActiveBorder;
            dgrDanhSachThe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachThe.GridColor = SystemColors.Info;
            dgrDanhSachThe.Location = new Point(317, 104);
            dgrDanhSachThe.Name = "dgrDanhSachThe";
            dgrDanhSachThe.RowHeadersWidth = 51;
            dgrDanhSachThe.Size = new Size(722, 443);
            dgrDanhSachThe.TabIndex = 13;
            dgrDanhSachThe.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(735, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 27);
            txtTimKiem.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Info;
            btnTimKiem.Location = new Point(991, 46);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(37, 27);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1051, 559);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dgrDanhSachThe);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnMoi);
            Controls.Add(btnThem);
            Controls.Add(cbTrangThai);
            Controls.Add(txtChuSoHuu);
            Controls.Add(txtMaThe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTheLuuDong";
            Text = "frmTheLuuDong";
            Load += frmTheLuuDong_Load;
            Resize += frmTheLuuDong_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachThe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaThe;
        private TextBox txtChuSoHuu;
        private CheckBox cbTrangThai;
        private Button btnThem;
        private Button btnMoi;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgrDanhSachThe;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}