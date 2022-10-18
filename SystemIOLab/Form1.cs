namespace SystemIOLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstSuruculer.Items.Clear();
            string[] suruculer = Directory.GetLogicalDrives();

            foreach (string s in suruculer)
            {
                lstSuruculer.Items.Add(s);  
            }
        }

        private void lstSuruculer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuruculer.SelectedIndices.Count == 0)
            {
                return;
            }

            lstKlasorler.DataSource = null;
            string SecilmisSurucuPath = lstSuruculer.SelectedItem.ToString();

            DirectoryInfo surucuInfo = new DirectoryInfo(SecilmisSurucuPath);
            try
            {
                DirectoryInfo[] klasörler = surucuInfo.GetDirectories();
                lstKlasorler.DisplayMember = "Name";
                lstKlasorler.ValueMember = "fullname";
                lstKlasorler.DataSource = klasörler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! --> " + ex.Message);
            }
        }

        private void lstKlasorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDosyalar.DataSource = null;
            ListBox lst = (ListBox)sender;
            if (lst.SelectedIndex == -1)
            {
                return;
            }

            DirectoryInfo secilenKlasor = (DirectoryInfo)lstKlasorler.SelectedItem;

            try
            {
                lstDosyalar.DisplayMember = "Name";
                FileInfo[] dosyalar = secilenKlasor.GetFiles();
                lstDosyalar.DataSource= dosyalar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosyalara erisimde hata oluştu! --> " + ex.Message);
                
            }
            
        }
    }
}