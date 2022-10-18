using Bogus;
using Bogus.Extensions.UnitedStates;

namespace Nuget_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faker faker = new Faker();
            txtAd.Text = faker.Person.FirstName;
            txtSoyad.Text = faker.Person.LastName;
            txtGsm.Text= faker.Person.Phone;
            txtEmail.Text = faker.Person.Email;
            txtDogumTarihi.Text= faker.Person.DateOfBirth.ToString();
            
            txtUlke.Text = faker.Address.Country();
            txtSehir.Text = faker.Address.City();

            // Olusan verileri Kayit.txt dosyasina atiniz.
            // 


        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}