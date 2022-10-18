namespace HAzırMetodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kelimeEkle_Click(object sender, EventArgs e)
        {
            yasakliListe.Items.Add(kelimeYaz.Text);
            kelimeYaz.Text = "";

        }

        private void calistir_Click(object sender, EventArgs e)
        {
            string newMetin = metin1.Text;
            foreach (var items in yasakliListe.Items)
            {
                newMetin = newMetin.Replace(items.ToString(), "*****");
                
            }
            metin2.Text = newMetin;
        }
    }
}