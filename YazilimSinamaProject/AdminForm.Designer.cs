namespace YazilimSinamaProject
{
    partial class AdminForm
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
            this.btnStokTakip = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnZimmetListele = new System.Windows.Forms.Button();
            this.btnUrunZimmetle = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnKullaniciIslemleri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.urunZimmetControl1 = new YazilimSinamaProject.UrunZimmetControl();
            this.urunIslemleriControl1 = new YazilimSinamaProject.UrunIslemleriControl();
            this.kullaniciIslemleriControl1 = new YazilimSinamaProject.KullaniciIslemleriControl();
            this.zimmetSorguControl2 = new YazilimSinamaProject.ZimmetSorguControl();
            this.stokTakipControl1 = new YazilimSinamaProject.StokTakipControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCik);
            this.panel1.Controls.Add(this.btnStokTakip);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlBtn);
            this.panel1.Controls.Add(this.btnZimmetListele);
            this.panel1.Controls.Add(this.btnUrunZimmetle);
            this.panel1.Controls.Add(this.btnUrunIslemleri);
            this.panel1.Controls.Add(this.btnKullaniciIslemleri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 477);
            this.panel1.TabIndex = 0;
            // 
            // lblCik
            // 
            this.lblCik.AutoSize = true;
            this.lblCik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCik.ForeColor = System.Drawing.Color.Orange;
            this.lblCik.Location = new System.Drawing.Point(9, 9);
            this.lblCik.Name = "lblCik";
            this.lblCik.Size = new System.Drawing.Size(24, 23);
            this.lblCik.TabIndex = 20;
            this.lblCik.Text = "X";
            this.lblCik.Click += new System.EventHandler(this.lblCik_Click);
            // 
            // btnStokTakip
            // 
            this.btnStokTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStokTakip.FlatAppearance.BorderSize = 0;
            this.btnStokTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTakip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokTakip.ForeColor = System.Drawing.Color.Coral;
            this.btnStokTakip.Location = new System.Drawing.Point(13, 377);
            this.btnStokTakip.Name = "btnStokTakip";
            this.btnStokTakip.Size = new System.Drawing.Size(194, 62);
            this.btnStokTakip.TabIndex = 5;
            this.btnStokTakip.Text = "Stok Takip";
            this.btnStokTakip.UseVisualStyleBackColor = false;
            this.btnStokTakip.Click += new System.EventHandler(this.btnStokTakip_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 64);
            this.panel3.TabIndex = 19;
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
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.Orange;
            this.pnlBtn.Location = new System.Drawing.Point(0, 105);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(14, 62);
            this.pnlBtn.TabIndex = 4;
            // 
            // btnZimmetListele
            // 
            this.btnZimmetListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZimmetListele.FlatAppearance.BorderSize = 0;
            this.btnZimmetListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetListele.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetListele.ForeColor = System.Drawing.Color.Coral;
            this.btnZimmetListele.Location = new System.Drawing.Point(6, 309);
            this.btnZimmetListele.Name = "btnZimmetListele";
            this.btnZimmetListele.Size = new System.Drawing.Size(194, 62);
            this.btnZimmetListele.TabIndex = 3;
            this.btnZimmetListele.Text = "Zimmet İşlemleri";
            this.btnZimmetListele.UseVisualStyleBackColor = false;
            this.btnZimmetListele.Click += new System.EventHandler(this.btnZimmetListele_Click_1);
            // 
            // btnUrunZimmetle
            // 
            this.btnUrunZimmetle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUrunZimmetle.FlatAppearance.BorderSize = 0;
            this.btnUrunZimmetle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunZimmetle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunZimmetle.ForeColor = System.Drawing.Color.Coral;
            this.btnUrunZimmetle.Location = new System.Drawing.Point(6, 241);
            this.btnUrunZimmetle.Name = "btnUrunZimmetle";
            this.btnUrunZimmetle.Size = new System.Drawing.Size(194, 62);
            this.btnUrunZimmetle.TabIndex = 2;
            this.btnUrunZimmetle.Text = "Ürün Zimmetle";
            this.btnUrunZimmetle.UseVisualStyleBackColor = false;
            this.btnUrunZimmetle.Click += new System.EventHandler(this.btnUrunZimmetle_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUrunIslemleri.FlatAppearance.BorderSize = 0;
            this.btnUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunIslemleri.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIslemleri.ForeColor = System.Drawing.Color.Coral;
            this.btnUrunIslemleri.Location = new System.Drawing.Point(6, 173);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(194, 62);
            this.btnUrunIslemleri.TabIndex = 1;
            this.btnUrunIslemleri.Text = "Ürün Alım/Satım";
            this.btnUrunIslemleri.UseVisualStyleBackColor = false;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnKullaniciIslemleri
            // 
            this.btnKullaniciIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKullaniciIslemleri.FlatAppearance.BorderSize = 0;
            this.btnKullaniciIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciIslemleri.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciIslemleri.ForeColor = System.Drawing.Color.Coral;
            this.btnKullaniciIslemleri.Location = new System.Drawing.Point(6, 105);
            this.btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            this.btnKullaniciIslemleri.Size = new System.Drawing.Size(194, 62);
            this.btnKullaniciIslemleri.TabIndex = 0;
            this.btnKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.btnKullaniciIslemleri.UseVisualStyleBackColor = false;
            this.btnKullaniciIslemleri.Click += new System.EventHandler(this.btnKullaniciIslemleri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 17);
            this.panel2.TabIndex = 1;
            // 
            // urunZimmetControl1
            // 
            this.urunZimmetControl1.Location = new System.Drawing.Point(206, 35);
            this.urunZimmetControl1.Name = "urunZimmetControl1";
            this.urunZimmetControl1.Size = new System.Drawing.Size(579, 430);
            this.urunZimmetControl1.TabIndex = 4;
            // 
            // urunIslemleriControl1
            // 
            this.urunIslemleriControl1.Location = new System.Drawing.Point(200, 35);
            this.urunIslemleriControl1.Name = "urunIslemleriControl1";
            this.urunIslemleriControl1.Size = new System.Drawing.Size(597, 393);
            this.urunIslemleriControl1.TabIndex = 3;
            // 
            // kullaniciIslemleriControl1
            // 
            this.kullaniciIslemleriControl1.Location = new System.Drawing.Point(206, 35);
            this.kullaniciIslemleriControl1.Name = "kullaniciIslemleriControl1";
            this.kullaniciIslemleriControl1.Size = new System.Drawing.Size(579, 430);
            this.kullaniciIslemleriControl1.TabIndex = 2;
            // 
            // zimmetSorguControl2
            // 
            this.zimmetSorguControl2.Location = new System.Drawing.Point(206, 35);
            this.zimmetSorguControl2.Name = "zimmetSorguControl2";
            this.zimmetSorguControl2.Size = new System.Drawing.Size(579, 430);
            this.zimmetSorguControl2.TabIndex = 5;
            // 
            // stokTakipControl1
            // 
            this.stokTakipControl1.Location = new System.Drawing.Point(200, 23);
            this.stokTakipControl1.Name = "stokTakipControl1";
            this.stokTakipControl1.Size = new System.Drawing.Size(597, 451);
            this.stokTakipControl1.TabIndex = 6;
            this.stokTakipControl1.Load += new System.EventHandler(this.stokTakipControl1_Load);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 477);
            this.Controls.Add(this.stokTakipControl1);
            this.Controls.Add(this.zimmetSorguControl2);
            this.Controls.Add(this.urunZimmetControl1);
            this.Controls.Add(this.urunIslemleriControl1);
            this.Controls.Add(this.kullaniciIslemleriControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnZimmetListele;
        private System.Windows.Forms.Button btnUrunZimmetle;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnKullaniciIslemleri;
        private System.Windows.Forms.Panel panel2;
        private KullaniciIslemleriControl kullaniciIslemleriControl1;
        private UrunIslemleriControl urunIslemleriControl1;
        private UrunZimmetControl urunZimmetControl1;
        private ZimmetSorguControl zimmetSorguControl2;
        private System.Windows.Forms.Button btnStokTakip;
        private StokTakipControl stokTakipControl1;
        private System.Windows.Forms.Label lblCik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}