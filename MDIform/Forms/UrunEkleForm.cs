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
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAdi = txtUrun.Text;
            urun.Barcode = txtBarkod.Text;
            urun.Fiyat = (int)nmrFiyat.Value;

            Context.urunler.Add(urun);

            DialogResult dialog = MessageBox.Show("Dialog eklendi yenisini ister misiniz?", "Dikkat", MessageBoxButtons.YesNo); 
            if (dialog == DialogResult.Yes) 
            { 
                txtUrun.Text = ""; 
                txtBarkod.Text = ""; 
                nmrFiyat.Value = 0; } 
            else 
            { 
                return; 
            }
        }
    }
}
