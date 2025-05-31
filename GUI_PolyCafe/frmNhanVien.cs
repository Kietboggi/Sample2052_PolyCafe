using BLL_PolyCafe;
using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            BUSNhanVien bUSNhanVien = new BUSNhanVien();
            dgvnhanvien.DataSource = null;
            dgvnhanvien.DataSource = bUSNhanVien.GetNhanVienList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                try
                {
                    // Lấy dữ liệu từ form
                    string maNV = txtMaNhanVien.Text.Trim();
                    string hoTen = txtHoTen.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string matKhau = txtMatKhau.Text.Trim();
                    string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
                    bool vaiTro;
                    if (rdoNhanVien.Checked)
                    {
                        vaiTro = true; // Nhân viên
                    }
                    else
                    {
                        vaiTro = false; // Quản lý
                    }

                    // Kiểm tra dữ liệu nhập vào
                    if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (matKhau != xacNhanMK)
                    {
                        MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tạo đối tượng nhân viên
                    NhanVien nv = new NhanVien
                    {
                        MaNhanVien = maNV,
                        HoTen = hoTen,
                        Email = email,
                        MatKhau = matKhau,
                        VaiTro = vaiTro,
                        TrangThai = true // Mặc định là active
                    };

                    // Gọi DAL để thêm nhân viên vào database
                    DALNhanVien nhanVienDLL = new DALNhanVien();
                    nhanVienDLL.insert(nv);

                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien(); // Làm mới form sau khi thêm thành công
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
           
        }
    }
}
