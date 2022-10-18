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
    public partial class frmUrunGuncelle : Form
    {
        private readonly Urun urun;

        public frmUrunGuncelle(Urun urun)
        {
            InitializeComponent();
            this.urun = urun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmUrunGuncelle_Load(object sender, EventArgs e)
        {
            txtBarkod.Text = urun.Barkode;
            txtUrun.Text = urun.UrunAdi;
            nmrFiyat.Value = urun.UrunFiyat;
        }
    }
}
