namespace YazilimSinamaProject
{
    partial class UserControl2
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
            this.btnStokTakip = new System.Windows.Forms.Button();
            this.grdStokTakip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdStokTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokTakip
            // 
            this.btnStokTakip.BackColor = System.Drawing.Color.Orange;
            this.btnStokTakip.FlatAppearance.BorderSize = 0;
            this.btnStokTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTakip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokTakip.ForeColor = System.Drawing.Color.White;
            this.btnStokTakip.Location = new System.Drawing.Point(16, 11);
            this.btnStokTakip.Name = "btnStokTakip";
            this.btnStokTakip.Size = new System.Drawing.Size(182, 55);
            this.btnStokTakip.TabIndex = 3;
            this.btnStokTakip.Text = "Stok Görüntüle";
            this.btnStokTakip.UseVisualStyleBackColor = false;
            this.btnStokTakip.Click += new System.EventHandler(this.btnStokTakip_Click);
            // 
            // grdStokTakip
            // 
            this.grdStokTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStokTakip.Location = new System.Drawing.Point(16, 72);
            this.grdStokTakip.Name = "grdStokTakip";
            this.grdStokTakip.RowHeadersVisible = false;
            this.grdStokTakip.RowTemplate.Height = 24;
            this.grdStokTakip.Size = new System.Drawing.Size(540, 348);
            this.grdStokTakip.TabIndex = 2;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStokTakip);
            this.Controls.Add(this.grdStokTakip);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(619, 447);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStokTakip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStokTakip;
        private System.Windows.Forms.DataGridView grdStokTakip;
    }
}
