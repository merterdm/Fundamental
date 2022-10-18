using MDIFormlar.Formlar;

namespace MDIFormlar
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkle urunEkle = new frmUrunEkle();
            urunEkle.MdiParent = this;
            urunEkle.Show();
        }

        private void urunYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListele urunlistesi= new();
            urunlistesi.MdiParent = this;
            urunlistesi.Show();
        }
    }
}