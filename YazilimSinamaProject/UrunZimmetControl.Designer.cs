namespace YazilimSinamaProject
{
    partial class UrunZimmetControl
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
            this.asdad = new System.Windows.Forms.Label();
            this.cmbKullaniciAdi = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunAd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZimmetle = new System.Windows.Forms.Button();
            this.btnZimmetCikar = new System.Windows.Forms.Button();
            this.cmbCikarilanAd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCikarilanMarka = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCikarilanModel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCikarilanKullaniciAdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnYenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asdad
            // 
            this.asdad.AutoSize = true;
            this.asdad.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asdad.ForeColor = System.Drawing.Color.Orange;
            this.asdad.Location = new System.Drawing.Point(25, 106);
            this.asdad.Name = "asdad";
            this.asdad.Size = new System.Drawing.Size(95, 17);
            this.asdad.TabIndex = 0;
            this.asdad.Text = "Kullanıcı Adı:";
            // 
            // cmbKullaniciAdi
            // 
            this.cmbKullaniciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciAdi.FormattingEnabled = true;
            this.cmbKullaniciAdi.Location = new System.Drawing.Point(126, 99);
            this.cmbKullaniciAdi.Name = "cmbKullaniciAdi";
            this.cmbKullaniciAdi.Size = new System.Drawing.Size(121, 24);
            this.cmbKullaniciAdi.TabIndex = 1;
            this.cmbKullaniciAdi.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciAdi_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(126, 189);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(27, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Modeli:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(126, 159);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 5;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(21, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Markası:";
            // 
            // cmbUrunAd
            // 
            this.cmbUrunAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunAd.FormattingEnabled = true;
            this.cmbUrunAd.Location = new System.Drawing.Point(126, 129);
            this.cmbUrunAd.Name = "cmbUrunAd";
            this.cmbUrunAd.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunAd.TabIndex = 7;
            this.cmbUrunAd.SelectedIndexChanged += new System.EventHandler(this.cmbUrunAd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Adı:";
            // 
            // btnZimmetle
            // 
            this.btnZimmetle.BackColor = System.Drawing.Color.Orange;
            this.btnZimmetle.FlatAppearance.BorderSize = 0;
            this.btnZimmetle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetle.ForeColor = System.Drawing.Color.White;
            this.btnZimmetle.Location = new System.Drawing.Point(126, 219);
            this.btnZimmetle.Name = "btnZimmetle";
            this.btnZimmetle.Size = new System.Drawing.Size(121, 58);
            this.btnZimmetle.TabIndex = 8;
            this.btnZimmetle.Text = "Zimmetle";
            this.btnZimmetle.UseVisualStyleBackColor = false;
            this.btnZimmetle.Click += new System.EventHandler(this.btnZimmetle_Click);
            // 
            // btnZimmetCikar
            // 
            this.btnZimmetCikar.BackColor = System.Drawing.Color.Orange;
            this.btnZimmetCikar.FlatAppearance.BorderSize = 0;
            this.btnZimmetCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetCikar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetCikar.ForeColor = System.Drawing.Color.White;
            this.btnZimmetCikar.Location = new System.Drawing.Point(370, 219);
            this.btnZimmetCikar.Name = "btnZimmetCikar";
            this.btnZimmetCikar.Size = new System.Drawing.Size(121, 58);
            this.btnZimmetCikar.TabIndex = 17;
            this.btnZimmetCikar.Text = "Zimmet Kaldır";
            this.btnZimmetCikar.UseVisualStyleBackColor = false;
            this.btnZimmetCikar.Click += new System.EventHandler(this.btnZimmetCikar_Click);
            // 
            // cmbCikarilanAd
            // 
            this.cmbCikarilanAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCikarilanAd.FormattingEnabled = true;
            this.cmbCikarilanAd.Location = new System.Drawing.Point(370, 129);
            this.cmbCikarilanAd.Name = "cmbCikarilanAd";
            this.cmbCikarilanAd.Size = new System.Drawing.Size(121, 24);
            this.cmbCikarilanAd.TabIndex = 16;
            this.cmbCikarilanAd.SelectedIndexChanged += new System.EventHandler(this.cmbCikarilanAd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(295, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ürün Adı:";
            // 
            // cmbCikarilanMarka
            // 
            this.cmbCikarilanMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCikarilanMarka.FormattingEnabled = true;
            this.cmbCikarilanMarka.Location = new System.Drawing.Point(370, 159);
            this.cmbCikarilanMarka.Name = "cmbCikarilanMarka";
            this.cmbCikarilanMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbCikarilanMarka.TabIndex = 14;
            this.cmbCikarilanMarka.SelectedIndexChanged += new System.EventHandler(this.cmbCikarilanMarka_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(265, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Markası:";
            // 
            // cmbCikarilanModel
            // 
            this.cmbCikarilanModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCikarilanModel.FormattingEnabled = true;
            this.cmbCikarilanModel.Location = new System.Drawing.Point(370, 189);
            this.cmbCikarilanModel.Name = "cmbCikarilanModel";
            this.cmbCikarilanModel.Size = new System.Drawing.Size(121, 24);
            this.cmbCikarilanModel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(271, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Modeli:";
            // 
            // cmbCikarilanKullaniciAdi
            // 
            this.cmbCikarilanKullaniciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCikarilanKullaniciAdi.FormattingEnabled = true;
            this.cmbCikarilanKullaniciAdi.Location = new System.Drawing.Point(370, 99);
            this.cmbCikarilanKullaniciAdi.Name = "cmbCikarilanKullaniciAdi";
            this.cmbCikarilanKullaniciAdi.Size = new System.Drawing.Size(121, 24);
            this.cmbCikarilanKullaniciAdi.TabIndex = 10;
            this.cmbCikarilanKullaniciAdi.SelectedIndexChanged += new System.EventHandler(this.cmbCikarilanKullaniciAdi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(269, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Orange;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(224, 18);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(159, 58);
            this.btnYenile.TabIndex = 18;
            this.btnYenile.Text = "Kullanıcıları Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunZimmetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnZimmetCikar);
            this.Controls.Add(this.cmbCikarilanAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCikarilanMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCikarilanModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCikarilanKullaniciAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnZimmetle);
            this.Controls.Add(this.cmbUrunAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKullaniciAdi);
            this.Controls.Add(this.asdad);
            this.Name = "UrunZimmetControl";
            this.Size = new System.Drawing.Size(626, 457);
            this.Load += new System.EventHandler(this.UrunZimmetControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asdad;
        private System.Windows.Forms.ComboBox cmbKullaniciAdi;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZimmetle;
        private System.Windows.Forms.Button btnZimmetCikar;
        private System.Windows.Forms.ComboBox cmbCikarilanAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCikarilanMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCikarilanModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCikarilanKullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnYenile;
    }
}
