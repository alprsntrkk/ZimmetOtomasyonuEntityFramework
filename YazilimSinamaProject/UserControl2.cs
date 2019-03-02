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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void btnStokTakip_Click(object sender, EventArgs e)
        {
            zimmetdbEntities db = new zimmetdbEntities();
            table.Clear();
            db.SaveChanges();
            foreach (Depo d in db.Depo)
            {
                foreach (Esya es in db.Esya)
                {
                    if (es.EsyaId == d.EsyaId)
                    {
                        table.Rows.Add(es.EsyaAdı, es.Marka, es.Model, d.StokMiktari);
                    }
                }
            }
            grdStokTakip.DataSource = table;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Eşya Adı", typeof(string));
            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Stok Miktarı", typeof(int));
        }
    }
}
