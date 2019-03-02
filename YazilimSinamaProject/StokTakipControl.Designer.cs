namespace YazilimSinamaProject
{
    partial class StokTakipControl
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
            this.grdStokTakip = new System.Windows.Forms.DataGridView();
            this.btnStokTakip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStokTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStokTakip
            // 
            this.grdStokTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStokTakip.Location = new System.Drawing.Point(8, 68);
            this.grdStokTakip.Name = "grdStokTakip";
            this.grdStokTakip.RowHeadersVisible = false;
            this.grdStokTakip.RowTemplate.Height = 24;
            this.grdStokTakip.Size = new System.Drawing.Size(514, 330);
            this.grdStokTakip.TabIndex = 0;
            // 
            // btnStokTakip
            // 
            this.btnStokTakip.BackColor = System.Drawing.Color.Orange;
            this.btnStokTakip.FlatAppearance.BorderSize = 0;
            this.btnStokTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTakip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokTakip.ForeColor = System.Drawing.Color.White;
            this.btnStokTakip.Location = new System.Drawing.Point(8, 25);
            this.btnStokTakip.Name = "btnStokTakip";
            this.btnStokTakip.Size = new System.Drawing.Size(156, 37);
            this.btnStokTakip.TabIndex = 1;
            this.btnStokTakip.Text = "Stok Görüntüle";
            this.btnStokTakip.UseVisualStyleBackColor = false;
            this.btnStokTakip.Click += new System.EventHandler(this.btnStokTakip_Click);
            // 
            // StokTakipControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStokTakip);
            this.Controls.Add(this.grdStokTakip);
            this.Name = "StokTakipControl";
            this.Size = new System.Drawing.Size(525, 401);
            this.Load += new System.EventHandler(this.StokTakipControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStokTakip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStokTakip;
        private System.Windows.Forms.Button btnStokTakip;
    }
}
