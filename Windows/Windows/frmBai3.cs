using System;
using System.Windows.Forms;

namespace Windows
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double diemToan, diemVan, diemAnh, diemChuan;
            if (!double.TryParse(txtDiemtoan.Text.Trim(), out diemToan) ||
                !double.TryParse(txtDiemVan.Text.Trim(), out diemVan) ||
                !double.TryParse(txtDiemAnh.Text.Trim(), out diemAnh) ||
                !double.TryParse(txtDiemChuan.Text.Trim(), out diemChuan))
            {
                MessageBox.Show("Vui lòng nhập điểm là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diemToan < 0 || diemToan > 10 || diemVan < 0 || diemVan > 10 || diemAnh < 0 || diemAnh > 10 || diemChuan < 0 || diemChuan > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double diemTrungBinh = (diemToan * 2 + diemVan * 2 + diemAnh) / 5.0;
            txtDiemTB.Text = diemTrungBinh.ToString("0.##");

            if (diemTrungBinh >= diemChuan)
            {
                txtKetQua.Text = "Đậu";
            }
            else
            {
                txtKetQua.Text = "Rớt";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtDiemtoan.Text = "";
            txtDiemVan.Text = "";
            txtDiemAnh.Text = "";
            txtDiemTB.Text = "";
            txtDiemChuan.Text = "";
            txtKetQua.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
