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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai1 fr = new frmBai1();
            fr.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 fr = new frmBai4();
            fr.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai5 fr = new frmBai5();
            fr.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai2 fr = new frmBai2();
            fr.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai3 fr = new frmBai3();
            fr.Show();
        }
    }
}
