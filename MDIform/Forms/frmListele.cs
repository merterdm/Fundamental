using MDIform.DBContext;
using MDIform.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIform.Forms
{
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
        }

        private void frmListele_Load(object sender, EventArgs e)
        {
            UrunleriEkle();
        }

        private void UrunleriEkle()
        {
            listView1.Items.Clear();
            foreach (Urun urun in Context.urunler)
            {
                string[] gosterlecekUrunler =
                {
                    urun.UrunAdi,
                    urun.Barcode,
                    urun.Fiyat.ToString() + "TL"
                };

                ListViewItem satir = new ListViewItem(gosterlecekUrunler);

                satir.Tag = urun;
                listView1.Items.Add(satir);
            }
        }

        private void btnLstEkle_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunEkle = new UrunEkleForm();
            urunEkle.MdiParent = this.MdiParent;
            urunEkle.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            UrunleriEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Önce silinecek kayıt seç.");
                return;         

            }
            ListViewItem secilmis = listView1.SelectedItems[0]; 
            Urun urun = (Urun) secilmis.Tag;
            DialogResult result = MessageBox.Show(urun.UrunAdi + "Adındaki ürün silinecektir. Emin misiniz? ", "Dikkat!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
            {
                Context.urunler.Remove(urun);
                UrunleriEkle();
            }
            else
                return;
        }
    }
}
