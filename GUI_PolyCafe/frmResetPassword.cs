using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using UTIL_PolyCafe;
using DAL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmResetPassword : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        DALNhanVien dALNhanVien = new DALNhanVien();
        public frmResetPassword()
        {
            InitializeComponent();
            btnShow.BringToFront();
            btnShowNew.BringToFront();
            btnShowNewA.BringToFront();
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //}
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin())
            {
                txtCPMaNV.Text = AuthUtil.user.MaNhanVien;
                txtCPTenNv.Text = AuthUtil.user.HoTen;

            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = btnHide.Visible ? '\0' : '*';
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnShowNewA_Click(object sender, EventArgs e)
        {

        }

        private void btnHideNewA_Click(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = btnHideNewA.Visible ? '\0' : '*';
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {

        }

        private void btnHideNew_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = btnHideNew.Visible ? '\0' : '*';
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ chưa đúng"); // "Old password is incorrect"
            }
            else
            {
                // Check if the new password matches the confirmation
                if (!txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp"); // "Password confirmation does not match"
                }
                else
                {
                    // Update the user's password
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;
                    dALNhanVien.update(AuthUtil.user); // Save updated user data
                    MessageBox.Show(this, "Đổi mật khẩu thành công"); // "Password changed successfully"
                }
            }

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
