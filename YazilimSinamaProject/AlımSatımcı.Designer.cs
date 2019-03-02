namespace YazilimSinamaProject
{
    partial class AlımSatımcı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTakip = new System.Windows.Forms.Button();
            this.pnlBtn2 = new System.Windows.Forms.Panel();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl11 = new YazilimSinamaProject.UserControl1();
            this.userControl21 = new YazilimSinamaProject.UserControl2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCik);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTakip);
            this.panel1.Controls.Add(this.pnlBtn2);
            this.panel1.Controls.Add(this.btnUrunIslemleri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 477);
            this.panel1.TabIndex = 13;
            // 
            // lblCik
            // 
            this.lblCik.AutoSize = true;
            this.lblCik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCik.ForeColor = System.Drawing.Color.Orange;
            this.lblCik.Location = new System.Drawing.Point(9, 14);
            this.lblCik.Name = "lblCik";
            this.lblCik.Size = new System.Drawing.Size(24, 23);
            this.lblCik.TabIndex = 22;
            this.lblCik.Text = "X";
            this.lblCik.Click += new System.EventHandler(this.lblCik_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 64);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // btnTakip
            // 
            this.btnTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTakip.FlatAppearance.BorderSize = 0;
            this.btnTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakip.ForeColor = System.Drawing.Color.Coral;
            this.btnTakip.Location = new System.Drawing.Point(6, 223);
            this.btnTakip.Name = "btnTakip";
            this.btnTakip.Size = new System.Drawing.Size(194, 62);
            this.btnTakip.TabIndex = 5;
            this.btnTakip.Text = "Stok Takip";
            this.btnTakip.UseVisualStyleBackColor = false;
            this.btnTakip.Click += new System.EventHandler(this.btnTakip_Click);
            // 
            // pnlBtn2
            // 
            this.pnlBtn2.BackColor = System.Drawing.Color.Orange;
            this.pnlBtn2.Location = new System.Drawing.Point(0, 155);
            this.pnlBtn2.Name = "pnlBtn2";
            this.pnlBtn2.Size = new System.Drawing.Size(14, 62);
            this.pnlBtn2.TabIndex = 4;
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUrunIslemleri.FlatAppearance.BorderSize = 0;
            this.btnUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunIslemleri.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIslemleri.ForeColor = System.Drawing.Color.Coral;
            this.btnUrunIslemleri.Location = new System.Drawing.Point(6, 155);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(194, 62);
            this.btnUrunIslemleri.TabIndex = 3;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = false;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 17);
            this.panel3.TabIndex = 14;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(200, 23);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(587, 432);
            this.userControl11.TabIndex = 15;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(202, 33);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(585, 432);
            this.userControl21.TabIndex = 16;
            // 
            // AlımSatımcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 477);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlımSatımcı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlımSatımcı";
            this.Load += new System.EventHandler(this.AlımSatımcı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTakip;
        private System.Windows.Forms.Panel pnlBtn2;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Panel panel3;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.Label lblCik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}