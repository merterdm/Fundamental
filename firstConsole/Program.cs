namespace firstConsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            Degisken isim verme kurallari
            1- Kullanmadigiz degiskenleri tanimlamayin
            2- Deger araligina gore degisken tipi secmeye özen gösterin
            3- DEgisken isimleri iki kelimeden olusturmayin. 
               Eger olusacak ise _ ile birbirinden ayirin
            4- Degisken isimleri asla sayi ile başlamaz.
               Ancak sayi bitebilir. Icinden sayi gecebilir.
             */

            int sayi1 = 0;
            int sa2 = 0;
            int s3a = 0;
            //byte	0 to 255

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            //short	-32,768 to 32,767
            Console.WriteLine("Short Max:" + short.MaxValue);
            Console.WriteLine("Short Min:" + short.MinValue);
            //ushort	0 to 65,535
            Console.WriteLine("UShort Max:" + ushort.MaxValue);
            Console.WriteLine("UShort Min:" + ushort.MinValue);
            //int	-2,147,483,648 to 2,147,483,647
            // Int32 = int
            Console.WriteLine("int Max:" + int.MaxValue);
            Console.WriteLine("int Min:" + int.MinValue);
            //uint	0 to 4,294,967,295
            Console.WriteLine("uint Max:" + uint.MaxValue);
            Console.WriteLine("uint Min:" + uint.MinValue);
            //long	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine("long Max:" + long.MaxValue);
            Console.WriteLine("long Min:" + long.MinValue);
            //ulong	0 to 18,446,744,073,709,551,615
            Console.WriteLine("ulong Max:" + ulong.MaxValue);
            Console.WriteLine("ulong Min:" + ulong.MinValue);

            //Floating-point numeric types
            // float	±1.5 x 10−45 to ±3.4 x 1038     
            Console.WriteLine("Float Max:" + float.MaxValue);
            Console.WriteLine("Float Min:" + float.MinValue);

            //double  ±5.0 × 10−324 to ±1.7 × 10308
            Console.WriteLine("Double Max:" + double.MaxValue);
            Console.WriteLine("Double Min:" + double.MinValue);
            //decimal	±1.0 x 10-28 to ±7.9228 x 1028
            Console.WriteLine("Decimal Max:" + decimal.MaxValue);
            Console.WriteLine("Decimal Min:" + decimal.MinValue);
            //Bool Veri Tipi:Default degeri false'dir
            bool cevap;
            // char veri tipi tek bir karakter tutmaya yarar
            char ch = 'a';
            Console.WriteLine(ch);

            // string veri tipi: Hazida Heap Tutulur 
            string str = "Son dakika haberi! Rusya Devlet Başkanı " +
                "Vladimir Putin'in, Ukrayna'nın Zaporijya Nükleer " +
                "Santrali'nin Rus mülkiyetine geçirilmesine yönelik " +
                "kararname imzaladığı bildirildi.\r\n\r\nKremlin " +
                "Sarayı'nın internet sayfasından yayımlanan Putin'in " +
                "imzaladığı kararnamede, Zaporijya Nükleer Santrali'nin " +
                "çalıştırılmasına ilişkin gerekli izinlerin verileceği " +
                "belirtildi.\r\n\r\nKararnamede, bu santralin " +
                "Rusya'nın federal mülkiyetine geçirileceği ve bu yönde Rus " +
                "hükümetine talimat verildiği kaydedildi.\r\n\r\nAVRUPA'NIN " +
                "EN BÜYÜK NÜKLEER SANTRALİ\r\n\r\nUkrayna'nın " +
                "güneydoğusundaki Zaporijya Nükleer Santrali, Avrupa'nın " +
                "en büyük nükleer santrali konumunda bulunuyor.\r\n\r\n6 nükleer " +
                "reaktör bulunan ve 5 bin 700 megavat/saat elektrik üretim " +
                "kapasitesine sahip santral, Ukrayna'daki toplam elektriğin " +
                "yüzde 20'sini sağlıyor.\r\n\r\nZaporijya Nükleer Santrali, " +
                "4 Mart'ta Ruslar tarafından ele geçirilmişti.";
            //Verbatim string literals @
            string haber = @"Son dakika haberi! Rusya Devlet Başkanı Vladimir Putin'in, Ukrayna'nın Zaporijya Nükleer Santrali'nin Rus mülkiyetine geçirilmesine yönelik kararname imzaladığı bildirildi.
Kremlin Sarayı'nın internet sayfasından yayımlanan Putin'in imzaladığı kararnamede, Zaporijya Nükleer Santrali'nin çalıştırılmasına ilişkin gerekli izinlerin verileceği belirtildi.
Kararnamede, bu santralin Rusya'nın federal mülkiyetine geçirileceği ve bu yönde Rus hükümetine talimat verildiği kaydedildi.
AVRUPA'NIN EN BÜYÜK NÜKLEER SANTRALİ
Ukrayna'nın güneydoğusundaki Zaporijya Nükleer Santrali, Avrupa'nın en büyük nükleer santrali konumunda bulunuyor.
6 nükleer reaktör bulunan ve 5 bin 700 megavat/saat elektrik üretim kapasitesine sahip santral, Ukrayna'daki toplam elektriğin yüzde 20'sini sağlıyor.
Zaporijya Nükleer Santrali, 4 Mart'ta Ruslar tarafından ele geçirilmişti.";

            // Escape Karakterler
            // \n => yeni satir
            // \t => tab yerine gecer
            // \b   backspace
            // \f	Form feed
            // \r Carriage return
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";
            s1 += s2;
            Console.WriteLine(s1);
            string columns = "Column 1\tColumn 2\tColumn 3";
            //Output: Column 1        Column 2        Column 3
            Console.WriteLine(columns);
            string rows = "Row 1\r\nRow 2\r\nRow 3";
            Console.WriteLine(rows);
            /* Output:
                Row 1
                Row 2
                Row 3
            */


            //$ string interpolation
            string veri = $"Bugunun tarihi {DateTime.Now.ToString()}";

            Console.WriteLine(veri);
            //DateTime Veri Tipi
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine("ToShort:" + DateTime.Now.ToShortTimeString());
            Console.WriteLine("ToLong:" + DateTime.Now.ToLongTimeString());
            Console.WriteLine("Day Of Week:" + DateTime.Now.DayOfWeek);
            Console.WriteLine("DayOfYear:" + DateTime.Now.DayOfYear);
            Console.WriteLine("TimeOfDay:" + DateTime.Now.TimeOfDay);



        }
    }
}