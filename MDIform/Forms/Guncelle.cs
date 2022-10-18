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
    public partial class Guncelle : Form
    {
        private readonly Urun urun;
        public Guncelle(Urun urun)
        {
            InitializeComponent();
            this.urun = urun;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
