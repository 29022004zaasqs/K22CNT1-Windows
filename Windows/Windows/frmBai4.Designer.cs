
namespace Windows
{
    partial class frmBai4
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.radcong = new System.Windows.Forms.RadioButton();
            this.radtru = new System.Windows.Forms.RadioButton();
            this.radchia = new System.Windows.Forms.RadioButton();
            this.radnhan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(372, 44);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(187, 20);
            this.txtSo1.TabIndex = 0;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(372, 101);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(176, 20);
            this.txtSo2.TabIndex = 1;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(357, 231);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(191, 20);
            this.txtKetqua.TabIndex = 2;
            // 
            // radcong
            // 
            this.radcong.AutoSize = true;
            this.radcong.Location = new System.Drawing.Point(20, 29);
            this.radcong.Name = "radcong";
            this.radcong.Size = new System.Drawing.Size(50, 17);
            this.radcong.TabIndex = 3;
            this.radcong.TabStop = true;
            this.radcong.Text = "Cộng";
            this.radcong.UseVisualStyleBackColor = true;
            this.radcong.CheckedChanged += new System.EventHandler(this.radcong_CheckedChanged);
            // 
            // radtru
            // 
            this.radtru.AutoSize = true;
            this.radtru.Location = new System.Drawing.Point(102, 29);
            this.radtru.Name = "radtru";
            this.radtru.Size = new System.Drawing.Size(41, 17);
            this.radtru.TabIndex = 4;
            this.radtru.TabStop = true;
            this.radtru.Text = "Trừ";
            this.radtru.UseVisualStyleBackColor = true;
            this.radtru.CheckedChanged += new System.EventHandler(this.radtru_CheckedChanged);
            // 
            // radchia
            // 
            this.radchia.AutoSize = true;
            this.radchia.Location = new System.Drawing.Point(296, 29);
            this.radchia.Name = "radchia";
            this.radchia.Size = new System.Drawing.Size(46, 17);
            this.radchia.TabIndex = 5;
            this.radchia.TabStop = true;
            this.radchia.Text = "Chia";
            this.radchia.UseVisualStyleBackColor = true;
            this.radchia.CheckedChanged += new System.EventHandler(this.radchia_CheckedChanged);
            // 
            // radnhan
            // 
            this.radnhan.AutoSize = true;
            this.radnhan.Location = new System.Drawing.Point(208, 29);
            this.radnhan.Name = "radnhan";
            this.radnhan.Size = new System.Drawing.Size(51, 17);
            this.radnhan.TabIndex = 6;
            this.radnhan.TabStop = true;
            this.radnhan.Text = "Nhân";
            this.radnhan.UseVisualStyleBackColor = true;
            this.radnhan.CheckedChanged += new System.EventHandler(this.radnhan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radcong);
            this.groupBox1.Controls.Add(this.radtru);
            this.groupBox1.Controls.Add(this.radchia);
            this.groupBox1.Controls.Add(this.radnhan);
            this.groupBox1.Location = new System.Drawing.Point(258, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Name = "frmBai4";
            this.Text = "Phép tính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.RadioButton radcong;
        private System.Windows.Forms.RadioButton radtru;
        private System.Windows.Forms.RadioButton radchia;
        private System.Windows.Forms.RadioButton radnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}