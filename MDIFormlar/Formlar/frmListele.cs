using MDIFormlar.DbContext;
using MDIFormlar.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormlar.Formlar
{
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
        }

        private void frmListele_Load(object sender, EventArgs e)
        {
            
            UrunleriYukle();
        }

        private void UrunleriYukle()
        {
           lstUrunler.Items.Clear();
            foreach (Urun urun in Db_context.Urunler)
            {

                // ListViewItem'a eklenecek veri seti olusturuluyor
                string[] gosterilecekUrunler =
                {
                   urun.UrunAdi,
                   urun.Barkode,
                   urun.UrunFiyat.ToString() + " TL"
                };

                ListViewItem satir = new ListViewItem(gosterilecekUrunler);

                // ListViewItem property 'sinden olan Tag propuna urunun kendisi ekleniyor
                satir.Tag = urun;
                lstUrunler.Items.Add(satir);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUrunEkle urunEkle = new frmUrunEkle();
            urunEkle.MdiParent = this.MdiParent ;
            urunEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Once silinecek kayit seciniz.");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;
            DialogResult result = MessageBox.Show(urun.UrunAdi + " adindaki urun silincektir Eminmisiniz ?", 
                                                   "Dikkat", 
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            { 
                Db_context.Urunler.Remove(urun);
                UrunleriYukle();
            }
            else
            {
                return;
            }
        }

        private void lstUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Guncelleme icin urun secmek gerekiyor");
                return;
            }
            else
            {
                ListViewItem secilen = lstUrunler.SelectedItems[0];
                Urun urun = (Urun)secilen.Tag;
                frmUrunGuncelle urunGuncelle = new frmUrunGuncelle(urun);
                urunGuncelle.MdiParent = this.MdiParent;
                urunGuncelle.Show();
            }
            
            //frmUrunGuncelle urunGuncelle = new frmUrunGuncelle();
        }
    }
}
