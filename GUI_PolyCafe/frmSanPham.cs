using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLPolyCafe;
using DTO_PolyCafe;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmSanPham : Form
    {
        BUSSanPham bUSSanPham = new BUSSanPham();
        public frmSanPham()
        {
            InitializeComponent();
            txtDonGia.Mask = "0000000000";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            rdtHoatDong.Checked = true;
            ptHinhAnh.Image = null;
        }
        private void LoadLoaiSanPham()
        {
            try
            {
                BUSLoaiSanPham bUSLoaiSanPham = new BUSLoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();
                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.ValueMember = "MaLoai";
                cboLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            BUSSanPham bUSSanPham = new BUSSanPham();
            dgvDanhSachSanPham.DataSource = null;
            List<SanPham> lstSP = bUSSanPham.GetSanPhamList();
            dgvDanhSachSanPham.DataSource = lstSP;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
