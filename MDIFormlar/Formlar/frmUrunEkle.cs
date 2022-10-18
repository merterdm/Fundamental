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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Urun urun = new Urun();
            urun.UrunAdi = txtUrun.Text;
            urun.Barkode=txtBarkod.Text;
            urun.UrunFiyat =(int)nmrFiyat.Value;

            Db_context.Urunler.Add(urun);

            DialogResult dialog = MessageBox.Show("Urun Eklendi .Yenisini eklemek istermisiniz ?", "Dikkat", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) 
            {
                txtUrun.Text = "";
                txtBarkod.Text = "";
                nmrFiyat.Value = 0;            
            }
            else 
            {
                this.Close();

            }
        }
    }
}
