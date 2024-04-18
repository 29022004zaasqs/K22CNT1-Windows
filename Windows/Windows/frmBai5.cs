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
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }


        private void frmBai5_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<= 12;i++)
            {
                cmbThang.Items.Add(i);
            }    
            for(int i=1900;i<=3000;i++)
            {
                cmbNam.Items.Add(i);
            }    
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int thang, nam;
            thang = int.Parse(cmbThang.Text);
            nam = int.Parse(cmbNam.Text);
            switch(thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    txtSongay.Text = "Tháng có 31 ngày:";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    txtSongay.Text = "Tháng có 30 ngày";
                    break;
                case 2:
                    if (nam % 4 == 0)
                        txtSongay.Text = "Tháng có 29 ngày";
                    else
                        txtSongay.Text = "Tháng có 28 ngày";
                    break;
            }    
        }
    }
}
