using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaProject
{
    public partial class UrunIslemleriControl : UserControl
    {
        public UrunIslemleriControl()
        {
            InitializeComponent();
        }
        zimmetdbEntities db = new zimmetdbEntities();
        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            
            UrunController.UrunKaydet(db, txtAlinanAd.Text, txtAlinanMarka.Text, txtAlinanModel.Text);
            cmbSatilanAd.Items.Clear();
            cmbStokAd.Items.Clear();
            foreach (Esya es in db.Esya)
            {
                cmbStokAd.Items.Add(es.EsyaAdı);
                cmbSatilanAd.Items.Add(es.EsyaAdı);
            }
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(txtSatilanMiktar.Text))|| (string.IsNullOrEmpty(cmbSatilanAd.SelectedText))|| (string.IsNullOrEmpty(cmbSatilanMarka.SelectedText))|| (string.IsNullOrEmpty(cmbSatilanModel.SelectedText)))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }
            UrunController.UrunSat(db, Convert.ToInt32(txtSatilanMiktar.Text), cmbSatilanAd.Text, cmbSatilanMarka.Text, cmbSatilanModel.Text);


        }

        private void UrunIslemleriControl_Load(object sender, EventArgs e)
        {
            foreach(Esya es in db.Esya)
            {
                if(!(cmbSatilanAd.Items.Contains(es.EsyaAdı)) && !(cmbStokAd.Items.Contains(es.EsyaAdı)))
                cmbSatilanAd.Items.Add(es.EsyaAdı.ToString());
                cmbStokAd.Items.Add(es.EsyaAdı.ToString());
            }
        }

        private void cmbSatilanAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSatilanMarka.Items.Clear();
            foreach(Esya es in db.Esya)
            {
                if ((es.EsyaAdı == cmbSatilanAd.Text) && !(cmbSatilanMarka.Items.Contains(es.Marka)))
                {
                    cmbSatilanMarka.Items.Add(es.Marka.ToString());
                }
            }
            
        }

        private void cmbSatilanMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSatilanModel.Items.Clear();
            foreach (Esya es in db.Esya)
            {
                if ((es.Marka == cmbSatilanMarka.Text)&&(es.EsyaAdı==cmbSatilanAd.Text) && !(cmbSatilanModel.Items.Contains(es.Model)))
                {
                    cmbSatilanModel.Items.Add(es.Model.ToString());
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStokArttır_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(txtMiktar.Text))|| (string.IsNullOrEmpty(cmbStokAd.SelectedItem.ToString()))|| (string.IsNullOrEmpty(cmbStokMarka.SelectedItem.ToString()))|| (string.IsNullOrEmpty(cmbStokModel.SelectedItem.ToString())))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }
            UrunController.UrunStokArttır(db, Convert.ToInt32(txtMiktar.Text), cmbStokAd.SelectedItem.ToString(), cmbStokMarka.SelectedItem.ToString(), cmbStokModel.SelectedItem.ToString());
        }


        private void cmbStokAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStokMarka.Items.Clear();
            foreach(Esya es in db.Esya)
            {
                if ((es.EsyaAdı == cmbStokAd.SelectedItem.ToString()) && !(cmbStokMarka.Items.Contains(es.Marka)))
                {
                    cmbStokMarka.Items.Add(es.Marka);
                }
            }
        }

        private void cmbStokMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStokModel.Items.Clear();
            foreach (Esya es in db.Esya)
            {
                if (es.Marka == cmbStokMarka.SelectedItem.ToString()&&(es.EsyaAdı==cmbStokAd.SelectedItem.ToString()) && !(cmbStokModel.Items.Contains(es.Model)))
                {
                    cmbStokModel.Items.Add(es.Model);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbSatilanModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAlinanMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlinanModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAlinanAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
