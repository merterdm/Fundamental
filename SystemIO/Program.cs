using System.IO;
using System.Text;

namespace SystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klasor işlemleri ciin Directory sinifi kullanilir

            //1- Klasor listei almak icin 

            #region DirectoryInfo

            //foreach (var item in Directory.GetDirectories(@"C:\Ercan"))
            //{

            //    Console.WriteLine(item.ToString());
            //}

            //foreach (var item in Directory.GetFiles(@"c:\Ercan"))
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //DirectoryInfo sonuc = Directory.CreateDirectory(@"c:\Ercan\Test");
            //Console.WriteLine(sonuc.FullName); 
            #endregion



            //DriveInfo :
            #region DriveInfo
            DriveInfo[] tumSuruculer = DriveInfo.GetDrives();
            foreach (var surucu in tumSuruculer)
            {
                Console.WriteLine(surucu.Name);
                Console.WriteLine(surucu.TotalSize);
                Console.WriteLine(surucu.DriveFormat);
                Console.WriteLine(surucu.DriveType);

            }
            #endregion

            #region File
            // File Static nesnedir.

            #region Dosya Okuma Yazma
            // FileStream : Dosyaya Yazmak icin 
            //FileStream fs = File.Create(@"c:\Ercan\deneme.txt");
            //Console.WriteLine(fs.Name);//Olusturulan dosyanin adini verir.
            //byte[] info = new UTF8Encoding(true).GetBytes(@"ZoomIt, uygulama tanıtımları içeren teknik sunular için bir ekran yakınlaştırma, ek açıklama ve kayıt aracıdır. ZoomIt, tepside göze çarpmadan çalışır ve ekranın bir alanını yakınlaştırmak, yakınlaştırılırken hareket etmek ve yakınlaştırılmış görüntü üzerinde çizim yapmak için özelleştirilebilir kısayol tuşlarıyla etkinleştirilir. ZoomIt'i özel ihtiyaçlarıma uyacak ve tüm sunularımda kullanacak şekilde yazdım.
            //                                                ZoomIt, Windows'un tüm sürümlerinde çalışır ve tabletlerde 
            //                                                ZoomIt çizimi için dokunmatik ve kalem girişini kullanabilirsiniz.");
            //fs.Write(info, 0, info.Length);
            //fs.Close();

            // silmek icin

            // File.Delete(@"c:\ercan\deneme.txt");



            // Var olan dosyay Yazmank icin Append metodu kullanilir

            //File.AppendAllText(@"c:\ercan\deneme.txt", "Bu satir sonradan eklenmistir", Encoding.UTF8);

            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText(@"c:\ercan\deneme.txt", $"{i} . Kere  eklenmistir\n", Encoding.UTF8);

            }
            #endregion

            #endregion

        }

        public static void DosyaOlustur()
        {
            FileStream fs = File.Create(@"c:\Ercan\deneme.txt");
            Console.WriteLine(fs.Name);//Olusturulan dosyanin adini verir.
            byte[] info = new UTF8Encoding(true).GetBytes(@"ZoomIt, uygulama tanıtımları içeren teknik sunular için bir ekran yakınlaştırma, ek açıklama ve kayıt aracıdır. ZoomIt, tepside göze çarpmadan çalışır ve ekranın bir alanını yakınlaştırmak, yakınlaştırılırken hareket etmek ve yakınlaştırılmış görüntü üzerinde çizim yapmak için özelleştirilebilir kısayol tuşlarıyla etkinleştirilir. ZoomIt'i özel ihtiyaçlarıma uyacak ve tüm sunularımda kullanacak şekilde yazdım.
                                                            ZoomIt, Windows'un tüm sürümlerinde çalışır ve tabletlerde 
                                                            ZoomIt çizimi için dokunmatik ve kalem girişini kullanabilirsiniz.");
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}