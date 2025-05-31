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

namespace GUI_PolyCafe
{
    public partial class frmTheLuuDong : Form
    {

        public frmTheLuuDong()
        {
            InitializeComponent();
        }

        private void frmTheLuuDong_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachThe();
        }
        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            cbTrangThai.Checked = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgrDanhSachThe.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
            txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            cbTrangThai.Checked = trangThai;

            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaThe.Enabled = false;
        }
        private void LoadDanhSachThe()
        {
            BUSTheLuuDong bUSTheLuuDong = new BUSTheLuuDong();
            dgrDanhSachThe.DataSource = null;
            dgrDanhSachThe.DataSource = bUSTheLuuDong.GetTheLuuDongList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();

            bool trangThai;

            if (cbTrangThai.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BUSTheLuuDong bus = new BUSTheLuuDong();
            string result = bus.InsertTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();

            bool trangThai;

            if (cbTrangThai.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }
            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BUSTheLuuDong bus = new BUSTheLuuDong();
            string result = bus.UpdateTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                if (dgrDanhSachThe.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachThe.SelectedRows[0];
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thẻ lưu động để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thẻ lưu động {maThe} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSTheLuuDong bus = new BUSTheLuuDong();
                string kq = bus.DeleteTheLuuDong(maThe);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin thẻ lưu động {maThe} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachThe();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachThe();
        }

        private void frmTheLuuDong_Resize(object sender, EventArgs e)
        {
            txtMaThe.Left = (this.ClientSize.Width - txtMaThe.Width) / 2;
            txtMaThe.Top = 10;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDanhSachThe();
                return;
            }

            BUSTheLuuDong bus = new BUSTheLuuDong();
            List<TheLuuDong> danhSach = bus.GetTheLuuDongList();

            var ketQua = danhSach.Where(the =>
                the.MaThe.ToLower().Contains(tuKhoa) ||
                the.ChuSoHuu.ToLower().Contains(tuKhoa) ||
                the.TrangThai.ToString().ToLower().Contains(tuKhoa)
            ).ToList();

            dgrDanhSachThe.DataSource = null;
            dgrDanhSachThe.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
