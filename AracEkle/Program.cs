namespace Ornek
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int sayi = 0, sayac = 0, bitir = 0, a = 0, depo = 0, depo2 = 0;
            string deger = "";
            List<int> list = new List<int>();
            List<int> onbes = new List<int>();
            List<int> asal = new List<int>();
            List<int> mukemmel = new List<int>();

            while (bitir == 0)
            {
                depo = 0;
                depo2 = 0;

                Console.WriteLine("Bir sayı giriniz.");
                deger = Console.ReadLine();
                sayac++;

                if (deger.ToUpper() == "END" || deger.ToUpper() == "EXIT" )
                {
                    if (sayac < 3)
                    {
                        Console.WriteLine("En az iki sayı girmelisiniz.");
                    }      
                }
                else if (deger.ToUpper() == "END" || deger.ToUpper() == "EXIT")
                {
                    if (sayac > 2)
                    {
                        bitir = 1;

                    }
                }
                else
                    sayi = Convert.ToInt32(deger);
                    list.Add(sayi);
                    onbes.Add(sayi % 15);

                //Asal
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        depo = 1;
                    }

                }

                if (depo == 0 && sayi != 1 && sayi != 0 && deger.ToUpper() != "END" && deger.ToUpper() != "EXIT")
                {
                    asal.Add(sayi);
                }

                //Mükemmel
                for (int j = 1; j < sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        depo2 = depo2 + j;
                    }
                }
                if (sayi == depo2)
                {
                    mukemmel.Add(sayi);
                    Console.WriteLine($"{sayi} sayısı mükemmel sayıdır.");
                }
            }

            Console.WriteLine("Max Değer: " + list.Max());
            Console.WriteLine("Min Değer: " + list.Min());
            Console.WriteLine("Değer Sayısı: " + list.Count);

            foreach (int item in onbes)
            {
                Console.WriteLine($"{list[a]}'nın 3 ile bölümündenkalan = {item}");
                a++;
            }
            foreach (int item in asal)
            {
                Console.WriteLine("Asal Sayılar: ");
                Console.WriteLine(item);
            }
            foreach (int item in mukemmel)
            {
                Console.WriteLine("Mükemmel Sayılar: ");
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
            
            
    }

    
}