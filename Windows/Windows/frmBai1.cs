using System;
using System.Windows.Forms;

namespace Windows
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (double.TryParse(txtSoluong.Text, out double soluong) && double.TryParse(txtDongia.Text, out double dongia))
            {
                double thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
            }
            else
            {
                // Nếu dữ liệu nhập không hợp lệ, hiển thị thông báo lỗi
                txtThanhtien.Text = "Dữ liệu không hợp lệ";
            }
        }

        private void txtDongia_TextChanged_1(object sender, EventArgs e)
        {

            if (double.TryParse(txtSoluong.Text, out double soluong) && double.TryParse(txtDongia.Text, out double dongia))
            {
                double thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoluong.Text = "";
            txtDongia.Clear();
            txtThanhtien.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", đóng ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
