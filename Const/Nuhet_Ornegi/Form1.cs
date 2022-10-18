using Bogus;
using System.Text;

namespace Nuhet_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            Faker faker = new Faker();
            isim.Text = faker.Person.FirstName;
            soyisim.Text = faker.Person.LastName;
            gsm.Text = faker.Person.Phone;
            email.Text = faker.Person.Email;
            sehir.Text = faker.Address.Country();
            Ulke.Text = faker.Address.City();
            numara.ToString();
            string yol = @"c:\berkay\deneme.txt";
            File.AppendAllText(yol, $"{numara.Text} Numarali Kullanici Bilgileri; \n\n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"Ad: {isim.Text} \n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"SoyAd: {soyisim.Text} \n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"Numara: {gsm.Text} \n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"Mail: {email.Text} \n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"Sehir: {sehir.Text} \n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"Ulke: {Ulke.Text} \n", Encoding.UTF8);
            File.AppendAllText(@"c:\berkay\deneme.txt", $"******************************************** \n\n", Encoding.UTF8);
            

        }

        private void numara_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}