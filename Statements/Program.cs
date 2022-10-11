namespace Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else

            //Console.WriteLine("kullanıcı kodu giriniz: ");
            //string username = Console.ReadLine();

            //if (username == "admin")
            //{
            //    Console.WriteLine("hoşgeldiniz, sayın admin...");
            //}
            //else
            //{
            //    Console.WriteLine("geçersiz kullanıcı adı!");
            //}

            #region EvenOrOdd
            //string giris;
            //int sayi;

            //Console.WriteLine("Sayıyı giriniz.");
            //giris = Console.ReadLine();
            //sayi = Convert.ToInt32(giris);

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine(" Girilen sayı çift.");
            //}
            //else
            //{
            //    Console.WriteLine(" Girilen sayı tek.");
            //}

            //Console.ReadLine(); 
            #endregion

            #region SolidLiquidGas
            //string giris;
            //int sayi;

            //Console.WriteLine("Sayıyı giriniz.");
            //giris = Console.ReadLine();
            //sayi = Convert.ToInt32(giris);

            //if (sayi <= 0)
            //{
            //    Console.WriteLine("Ürününüz buz formunda.");
            //}
            //else if (0 <= sayi && sayi <= 100) {
            //    Console.WriteLine("Ürününüz su formunda.");
            //}
            //else if(sayi >= 100)
            //{
            //    Console.WriteLine("Ürününüz buhar formunda.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz değer!");
            //}

            //Console.ReadLine();
            #endregion

            #region Login

            //Console.WriteLine("Type username");
            //String userId = Console.ReadLine();
            //Console.WriteLine("Type password");
            //String psw = Console.ReadLine();

            //String gercekDeger = "admin";
            //String gercekPsw = "123";



            //if (userId != gercekDeger && psw != gercekPsw)
            //{
            //    Console.WriteLine("Kullanıcı adı ve şifre yanlış!");

            //}
            //else if (userId == gercekDeger && psw == gercekPsw)
            //{
            //    Console.WriteLine("Merhaba Hoşgeldiniz...");
            //}
            //else
            //    Console.WriteLine("Geçersiz değer girdiniz!");

            //Console.ReadLine();

            #endregion

            #region Soru 3
            //string giris;
            //int sayi;

            //Console.WriteLine("Sayıyı giriniz.");
            //giris = Console.ReadLine();
            //sayi = Convert.ToInt32(giris);

            //if (0 <= sayi && sayi <= 30)
            //{
            //    Console.WriteLine("Notunuz: FF, Kaldınız!");
            //}
            //else if (30 <= sayi && sayi <= 50)
            //{
            //    Console.WriteLine("Notunuz: DD, Gelişmeye Çalış!");
            //}
            //else if (50 <= sayi && sayi <= 70)
            //{
            //    Console.WriteLine("Notunuz: BB, Geçtiniz!");
            //}
            //else if (70 <= sayi && sayi <= 100)
            //{
            //    Console.WriteLine("Notunuz: AA, Tebrikler!");
            //}
            //else
            //    Console.WriteLine("Geçersiz Değer!");
            #endregion

            #region Soru 4
            //Console.WriteLine("Ürün adı giriniz.");
            //string urun = Console.ReadLine();

            //if (urun == "Domates" || urun == "Biber" || urun == "Patlıcan")
            //{
            //    Console.WriteLine("Ürün Sebze reyonunda."); 
            //}
            //else if (urun == "Diş Macunu" || urun == "Parfüm" || urun == "Krem")
            //{
            //    Console.WriteLine("Ürün Kozmetik reyonunda.");
            //}
            //else if (urun == "Telefon" || urun == "Bilgisayar" || urun == "Ses Sistemleri")
            //{
            //    Console.WriteLine("Ürün Teknoloji reyonunda.");
            //}
            //else
            //    Console.WriteLine("Bu ürün bizde yok!");

            #endregion

            #region Soru 5            
            //int fiyat = 5, siparisAdet;
            //float indirimliTutar, toplamTutar, odenecekTutar;

            //Console.WriteLine("Sipariş sayısını giriniz.");            
            //siparisAdet = Convert.ToInt32(Console.ReadLine());

            //if (siparisAdet < 20)
            //{
            //    indirimliTutar = siparisAdet * 0.05f * fiyat;
            //    toplamTutar = siparisAdet * fiyat;
            //    odenecekTutar = toplamTutar - indirimliTutar;
            //    Console.WriteLine("Sipariş Sayısı: " + siparisAdet);
            //    Console.WriteLine("Ürün Fiyatı: " + fiyat);
            //    Console.WriteLine("Toplam Tutar: " + toplamTutar);
            //    Console.WriteLine("İndirim Oranı: 0.05");
            //    Console.WriteLine("İndirim Tutarı: " + indirimliTutar);
            //    Console.WriteLine("Ödenecek Tutar: " + odenecekTutar);
            //}
            //else if (siparisAdet >= 20 && siparisAdet < 50)
            //{
            //    indirimliTutar = siparisAdet * 0.1f * fiyat;
            //    toplamTutar = siparisAdet * fiyat;
            //    odenecekTutar = toplamTutar - indirimliTutar;
            //    Console.WriteLine("Sipariş Sayısı: " + siparisAdet);
            //    Console.WriteLine("Ürün Fiyatı: " + fiyat);
            //    Console.WriteLine("Toplam Tutar: " + toplamTutar);
            //    Console.WriteLine("İndirim Oranı: 0.1");
            //    Console.WriteLine("İndirim Tutarı: " + indirimliTutar);
            //    Console.WriteLine("Ödenecek Tutar: " + odenecekTutar);
            //}
            //else if (siparisAdet >= 50 && siparisAdet < 100) 
            //{
            //    indirimliTutar = siparisAdet * 0.15f * fiyat;
            //    toplamTutar = siparisAdet * fiyat;
            //    odenecekTutar = toplamTutar - indirimliTutar;
            //    Console.WriteLine("Sipariş Sayısı: " + siparisAdet);
            //    Console.WriteLine("Ürün Fiyatı: " + fiyat);
            //    Console.WriteLine("Toplam Tutar: " + toplamTutar);
            //    Console.WriteLine("İndirim Oranı: 0.15");
            //    Console.WriteLine("İndirim Tutarı: " + indirimliTutar);
            //    Console.WriteLine("Ödenecek Tutar: " + odenecekTutar);
            //}
            //else 
            //{
            //    indirimliTutar = siparisAdet * 0.2f * fiyat;
            //    toplamTutar = siparisAdet * fiyat;
            //    odenecekTutar = toplamTutar - indirimliTutar;
            //    Console.WriteLine("Sipariş Sayısı: " + siparisAdet);
            //    Console.WriteLine("Ürün Fiyatı: " + fiyat);
            //    Console.WriteLine("Toplam Tutar: " + toplamTutar);
            //    Console.WriteLine("İndirim Oranı: 0.20");
            //    Console.WriteLine("İndirim Tutarı: " + indirimliTutar);
            //    Console.WriteLine("Ödenecek Tutar: " + odenecekTutar);
            //}

            #endregion

            #region Ternary If
            //int x = 10, y = 100;          


            //var result = x > y ? "x büyüktür y" : "x küçüktür y";

            #endregion

            #region SwitchCase
            //string mesaj = "";
            //Console.WriteLine("Mevsim Giriniz: ");
            //string mevsim = Console.ReadLine();

            //switch (mevsim)
            //{
            //    case "Kış":
            //        mesaj = "Aralık, Ocak, Şubat";
            //        break;
            //    case "İlkbahar":
            //        mesaj = "Mart, Nisan, Mayıs";
            //        break;
            //    case "Yaz":
            //        mesaj = "Haziran, Temmuz, Auğustos";
            //        break;
            //    case "Sonbahar":
            //        mesaj = "Eylül, Ekim, Kasım";
            //        break;

            //    default:
            //        break;
            //}
            //Console.WriteLine(mesaj);

            #region Soru 1
            //string  giris = "";
            //Console.WriteLine("Rol Giriniz: ");
            //string rol = Console.ReadLine();

            //switch (rol)
            //{
            //    case "Admin":
            //        giris = "Admin sayfasına yönlendiriliyorsunuz...";
            //        break;
            //    case "Satış":
            //        giris = "Satış sayfasına yönlendiriliyorsunuz...";
            //        break;
            //    case "Üye":
            //        giris = "Üye sayfasına yönlendiriliyorsunuz...";
            //       break;

            //    default:
            //        break;
            //}
            //Console.WriteLine(giris);
            //Console.ReadLine();
            #endregion

            #region Soru 2
            //string giris = "";
            //Console.WriteLine("Ay numarasını giriniz: ");
            //string ay = Console.ReadLine();

            //switch (ay)
            //{
            //    case "1":
            //        giris = "Ocak";
            //        break;
            //    case "2":
            //        giris = "Şubat";
            //        break;
            //    case "3":
            //        giris = "Mart";
            //        break;
            //    case "4":
            //        giris = "Nisan";
            //        break;
            //    case "5":
            //        giris = "Mayıs";
            //        break;
            //    case "6":
            //        giris = "Haziran";
            //        break;
            //    case "7":
            //        giris = "Temmuz";
            //        break;
            //    case "8":
            //        giris = "Ağustos";
            //        break;
            //    case "9":
            //        giris = "Eylül";
            //        break;
            //    case "10":
            //        giris = "Ekim";
            //        break;
            //    case "11":
            //        giris = "Kasım";
            //        break;
            //    case "12":
            //        giris = "Aralık";
            //        break;

            //    default:
            //        break;
            //}
            //Console.WriteLine(giris);
            //Console.ReadLine();



            #endregion

            #region Soru 3
            //Console.WriteLine("Kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //Console.WriteLine("Şifre giriniz");
            //string psw = Console.ReadLine();

            //switch (username)
            //{
            //    case "admin":
            //        switch (psw)
            //        {
            //            case "123":
            //                Console.WriteLine("Tebrikler! Kullanıcı adı ve şifre doğru...");
            //                break;
            //            default:
            //                Console.WriteLine("Kullanıcı adı doğru fakat şifre yanlış.");
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Kullanıcı adınız yanlış. Şifreye bakmaya gerek bile yok!");
            //        break;
            //}


            #endregion

            #endregion


            #endregion

            #region Arrays
            //int[] sayilar = new int[3];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;

            //string[] sehirler = { "Adana", "Ankara", "İstanbul" };
            //double[] alfabe = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //---------------------------------------------------------
            //Console.WriteLine("Dizi boyutunu giriniz: ");
            //int boyut = Convert.ToInt32(Console.ReadLine());          
            //int[] sayilar = new int[boyut];

            //int index = 0;
            //Random random = new Random();
            //while (index < boyut)
            //{

            //    sayilar[index] = random.Next();
            //    index ++;
            //}

            //index = 0;
            //do
            //{
            //    Console.WriteLine(sayilar[index]);
            //    index++;
            //} while (index<boyut);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);

            //}

            #region Soru 1
            //0-100 arasında 50 elemanlı bir dizinin ort,vs...

            //Random random = new Random();

            //int[] sayilar2 = new int[50];
            //int cift = 0, tek = 0, toplam = 0, tekToplam = 0, ciftToplam = 0;
            //float ort;

            //Console.WriteLine("Dizideki tek elemanlar: ");
            //Console.WriteLine("-------------------------");
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    sayilar2[i] = random.Next(1, 100);
            //    toplam = toplam + sayilar2[i];
            //}


            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    if (sayilar2[i] % 2 == 0)
            //    {
            //        cift++;
            //        ciftToplam = ciftToplam + sayilar2[i];
            //    }
            //    else
            //    {
            //        tek++;
            //        tekToplam = tekToplam + sayilar2[i];
            //    }
            //}

            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}
            //ort = toplam / 50.0f;

            //Console.WriteLine("Dizideki tek eleman sayısı: " + tek);
            //Console.WriteLine("Dizideki çift eleman sayısı: " + cift);
            //Console.WriteLine("Dizideki sayıların ortalaması: " + ort);
            //Console.WriteLine("Dizideki tek sayıların toplamı: " + tekToplam + " / " + "Dizideki çift sayıların toplamı: " + ciftToplam);
            //Console.ReadLine(); 
            #endregion

            #region Soru 2
            //Ekrandan okutulan sayısın faktöriyeli
            //Console.WriteLine("Sayı Giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = sayi; i > 1; i--)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"Girilen {sayi} nın faktöriyeli {sonuc} tur");
            #endregion

            #region Soru 3

            //int tekToplam = 0, ciftToplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı Giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi == 0) {
            //        break;
            //    }
            //    else
            //        if (sayi % 2 == 0){
            //            ciftToplam++;
            //        }
            //        else
            //            tekToplam++;
            //}
            #endregion

            #region MyRegion
            //int tahminHakki = 10, tutulanSayi = 1, tahmin = 0, sayac = 0;
            //Random r = new Random();
            //tutulanSayi = r.Next(1,50);

            //do
            //{
            //    sayac++;

            //    Console.WriteLine($"{tahminHakki}. Tahmini Giriniz: ");
            //    tahmin =int.Parse( Console.ReadLine() );
            //    if (tahmin < tutulanSayi)
            //    {
            //        Console.WriteLine("Büyütün");
            //        tahminHakki--;
            //    }
            //    else if(tahmin > tutulanSayi)
            //    {
            //        Console.WriteLine("Küçültün");
            //        tahminHakki--;
            //    }
            //    else
            //        Console.WriteLine($"Tebrikler {sayac}. denemede buldunuz.);
            //} while (tahmin != tutulanSayi);

            //-----------------------------------------------------
            //int tahminHakki = 10, tutulanSayi = 1, tahmin = 0, sayac = 0;
            //Random r = new Random();
            //tutulanSayi = r.Next(1, 50);

            //for (int i = 1; i < 101; i++)
            //{
            //    for (int j = 1; j < 101; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }
            //    Console.WriteLine("----------------------------");
            //}

            #endregion

            #endregion

        }
    }
}