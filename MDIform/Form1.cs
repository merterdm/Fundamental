using MDIform.Forms;

namespace MDIform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunEkle = new UrunEkleForm();
            urunEkle.MdiParent = this;
            urunEkle.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListele frmListele = new frmListele();
            frmListele.MdiParent = this;
            frmListele.Show();
        }
    }
}