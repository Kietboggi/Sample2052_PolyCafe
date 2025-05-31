﻿namespace GUI_PolyCafe
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(414, 111);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(418, 224);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.Location = new Point(418, 147);
            txtUsername.Margin = new Padding(7, 8, 7, 8);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(366, 36);
            txtUsername.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.Maroon;
            chkShowPassword.Location = new Point(418, 317);
            chkShowPassword.Margin = new Padding(3, 4, 3, 4);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(148, 24);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Hiển thị mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(419, 405);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 60);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSalmon;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(419, 497);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(366, 60);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(419, 253);
            txtPassword.Margin = new Padding(7, 8, 7, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(366, 36);
            txtPassword.TabIndex = 2;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 645);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(889, 692);
            MinimumSize = new Size(889, 692);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += Login_FormClosing;
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnExit;
        private TextBox txtPassword;
    }
}