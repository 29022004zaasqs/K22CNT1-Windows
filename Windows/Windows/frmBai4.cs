using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void radcong_CheckedChanged(object sender, EventArgs e)
        {
            if(radcong.Checked)
            {
                double so1, so2;
                if(double.TryParse(txtSo1.Text,out so1) & double.TryParse(txtSo2.Text,out so2))
                {
                    txtKetqua.Text = (so1 + so2).ToString();
                }    
            }    
        }

        private void radtru_CheckedChanged(object sender, EventArgs e)
        {
            if (radtru.Checked)
            {
                double so1, so2;
                if (double.TryParse(txtSo1.Text, out so1) & double.TryParse(txtSo2.Text, out so2))
                {
                    txtKetqua.Text = (so1 - so2).ToString();
                }
            }
        }

        private void radnhan_CheckedChanged(object sender, EventArgs e)
        {
            if (radnhan.Checked)
            {
                double so1, so2;
                if (double.TryParse(txtSo1.Text, out so1) & double.TryParse(txtSo2.Text, out so2))
                {
                    txtKetqua.Text = (so1 * so2).ToString();
                }
            }
        }

        private void radchia_CheckedChanged(object sender, EventArgs e)
        {
            if (radchia.Checked)
            {
                double so1, so2;
                if (double.TryParse(txtSo1.Text, out so1) & double.TryParse(txtSo2.Text, out so2))
                {
                    txtKetqua.Text = (so1 / so2).ToString();
                }
            }
        }
    }
}
