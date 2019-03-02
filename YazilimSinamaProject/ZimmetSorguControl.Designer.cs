namespace YazilimSinamaProject
{
    partial class ZimmetSorguControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdZimmet = new System.Windows.Forms.DataGridView();
            this.asdasd = new System.Windows.Forms.Label();
            this.btnKullaniciSorgula = new System.Windows.Forms.Button();
            this.cmbKullaniciAdi = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmet)).BeginInit();
            this.SuspendLayout();
            // 
            // grdZimmet
            // 
            this.grdZimmet.BackgroundColor = System.Drawing.Color.Orange;
            this.grdZimmet.ColumnHeadersHeight = 41;
            this.grdZimmet.Location = new System.Drawing.Point(3, 110);
            this.grdZimmet.Name = "grdZimmet";
            this.grdZimmet.RowHeadersVisible = false;
            this.grdZimmet.RowTemplate.Height = 24;
            this.grdZimmet.Size = new System.Drawing.Size(576, 277);
            this.grdZimmet.TabIndex = 0;
            // 
            // asdasd
            // 
            this.asdasd.AutoSize = true;
            this.asdasd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asdasd.ForeColor = System.Drawing.Color.Orange;
            this.asdasd.Location = new System.Drawing.Point(242, 36);
            this.asdasd.Name = "asdasd";
            this.asdasd.Size = new System.Drawing.Size(150, 17);
            this.asdasd.TabIndex = 1;
            this.asdasd.Text = "Kullanıcı Adına Göre:";
            // 
            // btnKullaniciSorgula
            // 
            this.btnKullaniciSorgula.BackColor = System.Drawing.Color.Orange;
            this.btnKullaniciSorgula.FlatAppearance.BorderSize = 0;
            this.btnKullaniciSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSorgula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSorgula.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciSorgula.Location = new System.Drawing.Point(398, 59);
            this.btnKullaniciSorgula.Name = "btnKullaniciSorgula";
            this.btnKullaniciSorgula.Size = new System.Drawing.Size(121, 45);
            this.btnKullaniciSorgula.TabIndex = 2;
            this.btnKullaniciSorgula.Text = "Sorgula";
            this.btnKullaniciSorgula.UseVisualStyleBackColor = false;
            this.btnKullaniciSorgula.Click += new System.EventHandler(this.btnKullaniciSorgula_Click);
            // 
            // cmbKullaniciAdi
            // 
            this.cmbKullaniciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciAdi.FormattingEnabled = true;
            this.cmbKullaniciAdi.Location = new System.Drawing.Point(398, 29);
            this.cmbKullaniciAdi.Name = "cmbKullaniciAdi";
            this.cmbKullaniciAdi.Size = new System.Drawing.Size(121, 24);
            this.cmbKullaniciAdi.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Orange;
            this.btnListele.FlatAppearance.BorderSize = 0;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(59, 29);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 75);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Tüm Listeyi Getir";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Orange;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(257, 59);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(121, 45);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // ZimmetSorguControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbKullaniciAdi);
            this.Controls.Add(this.btnKullaniciSorgula);
            this.Controls.Add(this.asdasd);
            this.Controls.Add(this.grdZimmet);
            this.Name = "ZimmetSorguControl";
            this.Size = new System.Drawing.Size(582, 390);
            this.Load += new System.EventHandler(this.ZimmetSorguControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdZimmet;
        private System.Windows.Forms.Label asdasd;
        private System.Windows.Forms.Button btnKullaniciSorgula;
        private System.Windows.Forms.ComboBox cmbKullaniciAdi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYenile;
    }
}
