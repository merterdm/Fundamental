using System.Collections;

namespace ArrListOrn
{
    struct Ogrenci
    {
        string Ad;
        string Soyad;
        string TcNo;
        string Cinsiyet;
        string DogumTarihi;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList yeniDizi = new ArrayList();
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //yeniDizi.Add(15);
            //yeniDizi.Add("Ali");
            //yeniDizi.Add(DateTime.Now);
            //yeniDizi.Add(sayilar);

            //List<int> sayilar = new List<int>();
            //Random r = new Random();
            //int a = 0;
            //int sayac = 0;


            //while (sayac < 50)
            //{
            //    int sayi = r.Next(1, 100);
            //    a = 0;
            //    if (sayilar.Contains(sayi))
            //    {
            //        a = 1;
            //        Console.WriteLine($"{sayi} sayısı mevcut. Başka bir sayı ekleyeceğim.");
            //    }
            //    if (a == 0) {
            //        sayilar.Add(sayi);
            //        Console.WriteLine($"{sayi} sayısı eklendi.");
            //        sayac++;
            //    }
            //}
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            Ogrenci ogrenci = new Ogrenci();

        //    int sayac = 0;
        //    int a = 0;  
        //    while (true)
        //    {

        //    }
        //    Console.WriteLine("1- Öğrenci Kayıt");
        //    Console.WriteLine("2- Öğrenci Listesi");
        //    Console.WriteLine("1- Çıkış");
            
        //    string secim = Console.ReadLine();  
        //    List<string> adList = new List<string>();
        //    List<string> soyadList = new List<string>();        
        //    List<string> tcList = new List<string>();        
        //    List<string> genderList = new List<string>();        
        //    List<string> birthList = new List<string>();        
        //    switch (secim)
        //    {
        //        case "1":
        //            {
        //                Console.WriteLine("Adınızı Giriniz.");
        //                string ad = Console.ReadLine();
        //                Console.WriteLine("Soyadınızı Giriniz.");
        //                string soyAd = Console.ReadLine();
        //                Console.WriteLine("Tc No Giriniz.");
        //                string tc = Console.ReadLine();
        //                Console.WriteLine("Cinsiyetinizi Giriniz.");
        //                string cinsiyet = Console.ReadLine();
        //                Console.WriteLine("Doğum Tarihinizi Giriniz.");
        //                string birth = Console.ReadLine();
                        
        //                adList.Add(ad);
        //                soyadList.Add(soyAd);
        //                tcList.Add(tc);
        //                genderList.Add(cinsiyet);
        //                birthList.Add(birth);
        //            }
        //            break;
        //    case "2":
        //            {
        //                for (int i = 0; i < length; i++)
        //                {

        //                }
        //            }
        //            break;
        //    case "3":
        //            {

        //            }
        //            break;
        //        default:
        //            break;
        //    }


        }
    }
}