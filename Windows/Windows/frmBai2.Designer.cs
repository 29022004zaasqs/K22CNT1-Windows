
namespace Windows
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labten = new System.Windows.Forms.Label();
            this.labngaysinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnmo = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labten
            // 
            this.labten.AutoSize = true;
            this.labten.Location = new System.Drawing.Point(315, 87);
            this.labten.Name = "labten";
            this.labten.Size = new System.Drawing.Size(60, 13);
            this.labten.TabIndex = 0;
            this.labten.Text = "Your Name";
            // 
            // labngaysinh
            // 
            this.labngaysinh.AutoSize = true;
            this.labngaysinh.Location = new System.Drawing.Point(315, 137);
            this.labngaysinh.Name = "labngaysinh";
            this.labngaysinh.Size = new System.Drawing.Size(62, 13);
            this.labngaysinh.TabIndex = 1;
            this.labngaysinh.Text = "year of birth";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 2;

            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(443, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 20);
            this.textBox2.TabIndex = 3;

            // 
            // btnmo
            // 
            this.btnmo.Location = new System.Drawing.Point(397, 202);
            this.btnmo.Name = "btnmo";
            this.btnmo.Size = new System.Drawing.Size(75, 23);
            this.btnmo.TabIndex = 4;
            this.btnmo.Text = "Show";
            this.btnmo.UseVisualStyleBackColor = true;
            this.btnmo.Click += new System.EventHandler(this.btnmo_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(612, 202);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Exit";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(508, 202);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Clear";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnmo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labngaysinh);
            this.Controls.Add(this.labten);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labten;
        private System.Windows.Forms.Label labngaysinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnmo;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
    }
}