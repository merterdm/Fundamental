namespace MethodOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Birlestir("Mert", "Erdem"));
            Console.WriteLine(Faktoriyel(12));
            Console.WriteLine(MutlakDeger(-13));
            Console.WriteLine(UsAlma(2,5));
            Console.WriteLine(Discriminant(2,5,4));
            Console.ReadLine();
        }

        static string Birlestir(string yazi1, string yazi2)
        {
            return yazi1 + " " + yazi2;
        }

        static ulong Faktoriyel(int sayi)
        {
            ulong faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= (ulong)i;
            }
            return faktoriyel;

        }
        static int MutlakDeger(int sayi)
        {

            if (sayi < 0)
            {
                return sayi * -1;
            }
            else
                return sayi;
        }

        static int UsAlma(int sayi, int sayi2) {
            int toplam = 1;
            for (int i = 0; i < sayi2; i++)
            {
                toplam = toplam * sayi;
            }
            return toplam;
        }

        static double Discriminant(double a, double b, double c) {

            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                Console.WriteLine($"Sayının discriminantı budur: {discriminant}, pozitiftir. "); 
                Console.WriteLine("Dolayısıyla tek sonuç."); 
                
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Sayının discriminantı budur: {discriminant}, sıfırdır.");
                Console.WriteLine("Dolayısıyla çift sonuç.");
                
            }
            else if (discriminant < 0)
            {
                Console.WriteLine($"Sayının discriminantı budur: {discriminant}, negatiftir.");
                Console.WriteLine("Dolayısıyla sonuç yok.");
                
            }
            return discriminant;
         

        }

        static bool Login(string username, string password)
        {
            if (username == "admin" && password == "123")
                return true;
            else
                return false;
        }

        static string YeniKod(string code)
        {
            string number = "";
            foreach (char item in code)
            {
                if (char.IsDigit(item))
                {
                    number += item;
                }
                else
                    number = "";
            }
            if (number == "")
            {
                number = "1";
            }
            else
            {
                number = (int.Parse(number) + 1).ToString();
            }
            var newNumber = number; 
            var fark = code.Length-(number.Length-(newNumber.Length-number.Length));

            if (fark < 0)
            {
                fark = 0;
            }
            var newCode = code.Substring(0, fark);
            newCode += newNumber;

            return newCode;
        }

        static int Topla(int a params int[] sayilar)
        {
            int toplam = a;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;

        }
    }

}