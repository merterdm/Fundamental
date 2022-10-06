namespace ReadData2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ekrandan Veri Okuma
            //string? giris;
            //int sayi1, sayi2;

            //Console.WriteLine("Birinci sayıyı giriniz.");
            //giris = Console.ReadLine();
            //sayi1 = Convert.ToInt32(giris);

            //Console.WriteLine("İkinci sayıyı giriniz.");
            //giris = Console.ReadLine();
            //sayi2 = Convert.ToInt32(giris);

            ////Console.WriteLine("Girilen Sayılar {0} ve {1}", sayi1,sayi2);
            //Console.WriteLine($"Girilen Sayılar {sayi1} ve {sayi2}");
            ////Console.WriteLine("Girilen Sayılar " + sayi1 + " ve " + sayi2); 
            #endregion

            #region Aritmatik Islemler
            //int a = 5; int b = 32; int c = 0; /*int d = 5*/;

            //Console.WriteLine($"{b} nin {a} ya bölümünden kalan {b%a}");
            //c = a + b;
            //c = 0;
            //b++;
            //c = a + b;

            //Console.WriteLine("Sonuç: " + c);
            #endregion



            #region Çözüm 1
            //string giris, giris2;
            //int a ; int b; int islem;

            //Console.WriteLine("Birinci sayıyı giriniz.");
            //giris = Console.ReadLine();
            //a = Convert.ToInt32(giris);

            //Console.WriteLine("İkinci sayıyı giriniz.");
            //giris2 = Console.ReadLine();
            //b = Convert.ToInt32(giris2);

            //Console.WriteLine($"Toplamı= {a + b}, Farkı= {a - b}, İki değerin modu= {(a+b)%(a-b)}");

            //Console.WriteLine("Çıkmak için enter tuşuna basınız...");
            //Console.ReadLine();
            #endregion

            #region Çözüm 2
            //string giris, giris2;
            //int a; int b; int islem; int islem2;

            //Console.WriteLine("Birinci sayıyı giriniz.");
            //giris = Console.ReadLine();
            //a = Convert.ToInt32(giris);

            //Console.WriteLine("İkinci sayıyı giriniz.");
            //giris2 = Console.ReadLine();
            //b = Convert.ToInt32(giris2);
            //islem = ((a - 10) * (a - 10) % 3);
            //islem2 = ((a - 10) * (a - 10) % 3);

            //Console.WriteLine($"{a}' nın 10 eksiğinin 3'e bölümünden kalanı {islem}, {b}' nin 10 eksiğinin 3'e bölümünden kalanı {islem2}");

            //Console.WriteLine("Çıkmak için enter tuşuna basınız...");
            //Console.ReadLine();
            #endregion

            #region Çözüm 3
            //string giris, giris2;
            //int a; int b; int islem; int islem2;

            //Console.WriteLine("Birinci sayıyı giriniz.");
            //giris = Console.ReadLine();
            //a = Convert.ToInt32(giris);

            //Console.WriteLine("İkinci sayıyı giriniz.");
            //giris2 = Console.ReadLine();
            //b = Convert.ToInt32(giris2);

            //islem = ((a * a) + (b * b));
            //islem2 = ((a * a) - (b * b));

            //Console.WriteLine($" İki sayının karelerinin toplamı {islem}' farkı ise {islem2}' dir, bu iki sayının toplamı= {islem + islem2}'dir.");

            //Console.WriteLine("Çıkmak için enter tuşuna basınız...");
            //Console.ReadLine();
            #endregion

            #region Çözüm 4
            //-----------------Manuel Çözüm--------------
            //float vize, vize2, final, ortalama, sonuc;
            //vize = 42.7f;
            //vize2 = 55.8f;
            //ortalama = (vize + vize2) / 2;
            //final = 60;
            //sonuc = ortalama * 0.3f + final * 0.7f;

            //Console.WriteLine($"Sonuç: {sonuc} ");


            //---------------Diğer Yapım------------------
            string giris, giris2, giris3;
            int a, b, c;
            float islem, islem2, islem3;
            Console.WriteLine("Birinci Vize Giriniz: ");
            giris = Console.ReadLine();
            a = Convert.ToInt32(giris);
            Console.WriteLine("Ikinci Vize Giriniz: ");
            giris2 = Console.ReadLine();
            b = Convert.ToInt32(giris2);
            Console.WriteLine("Final Giriniz: ");
            giris3 = Console.ReadLine();
            c = Convert.ToInt32(giris3);
            islem = (a + b) / 2;
            islem2 = (islem * 30) / 100;
            islem3 = (c * 70) / 100;
            if (c >= 60)
            {
                if (islem2 + islem3 >= 50)
                {
                    Console.WriteLine($"Birinci vizeniz {a},ikinci vizeniz {b}, final notunuz {c}, Ortalamaniz = {islem2 + islem3} >> Geçtiniz");
                }
                else
                {
                    Console.WriteLine($"Birinci vizeniz {a},ikinci vizeniz {b}, final notunuz {c}, Ortalamaniz = {islem2 + islem3} >> Kaldınız");
                }
            }
            else
            {
                Console.WriteLine($"Birinci vizeniz {a},ikinci vizeniz {b}, final notunuz {c}, Ortalamaniz = {islem2 + islem3} >> Kaldınız");
            }

            Console.WriteLine("Çıkmak için enter tuşuna basınız...");
            Console.ReadLine(); 
            #endregion
        }
            
    }
}