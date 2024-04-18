using System;
using System.Windows.Forms;

namespace Windows
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string yearOfBirthText = textBox2.Text.Trim();
            int yearOfBirth;

            if (string.IsNullOrEmpty(name) || !int.TryParse(yearOfBirthText, out yearOfBirth))
            {
                MessageBox.Show("Tên không được để trống và Năm sinh phải là một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int age = DateTime.Now.Year - yearOfBirth;
            MessageBox.Show($"Tên: {name}\nTuổi: {age}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
