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

        static string 

    }

}