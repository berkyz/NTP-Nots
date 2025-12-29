namespace Ders10f
{
    internal class Program
    {
        static void Main(string[] args)
        {

            File.Replace("C:/Users/lenovo/Desktop/metin5.txt", "C:/Users/lenovo/source/metin.txt", "C:/Users/lenovo/source/yedek.txt");


            //if(File.Exists("C:/Users/lenovo/source/metin2.txt"))
            //    Console.WriteLine("Dosyayı taşıyamamışsın!");
            //else
            //    Console.WriteLine("Dosya taşınmış.");

            // File.Move("C:/Users/lenovo/source/metin2.txt", "C:/Users/lenovo/Desktop/metin5.txt");
            // File.Delete("C:/Users/lenovo/Desktop/dortisim.txt");
            

            //string yeniIsim = "Beyza";
            //File.AppendAllText("C:/Users/lenovo/Desktop/dortisim.txt", yeniIsim+"\n");
            //File.AppendAllText("C:/Users/lenovo/Desktop/dortisim.txt", "Emre"+"\n");


            //string[] adlar2 = { "Berk", "Can", "Ela", "Naz" };
            //File.AppendAllLines("C:/Users/lenovo/Desktop/dortisim.txt", adlar2);

            // File.Copy("C:/Users/lenovo/source/metin2.txt", "C:/Users/lenovo/Desktop/dortisim.txt");

            //string[] adlar = {"Ali", "Cem", "Eda", "Nur" };
            //File.WriteAllLines("C:/Users/lenovo/source/metin2.txt", adlar);

            //            string metin = @"
            //Merhaba, bu dersimizde dosya işlemlerinden bahsedeceğiz. Dosya işlemlerinden kastımız, bir dosyadan okumak ve bir dosyaya yazmak. Bu işlemler haricinde dosyalarla alakalı olan birkaç sınıftan da bahsedeceğiz. Aslında dosyalarla ilgili anlatılacak şeyler çok fazla ve bir makaleye sığmaz; ancak bu makalede sadece önemli noktalardan ve en çok kullanabileceğiniz şeylerden bahsedeceğiz.
            //Directory ve File Sınıfları
            //Directory ve File sınıfları System.IO isim alanında (namespace) bulunur. Dolayısıyla bu sınıfları kullanabilmek için, programımıza using System.IO; satırını eklemeliyiz. Directory ve File sınıflarında statik metotlar bulunur. Bu iki sınıfın birçok metodu benzerdir. Tek farkları Directory sınıfı klasörler üzerinde işlem yaparken File sınıfı dosyalar üzerinde işlem yapar. Bu metotlara örnek olarak Delete, Exists ve Move’u verebiliriz. Aşağıdaki kod bloğunda Directory ve File sınıfına ait bazı metotların kullanımını ve açıklamalarını görebilirsiniz.

            //        C#
            //            static void Main(string[] args)
            //            {
            //                string directory = ""C:\\Folder"";
            //                string file = ""C:\\Folder\\File.txt"";

            //                Directory.CreateDirectory(directory); //Klasör oluşturur
            //                bool isDirectoryExists = Directory.Exists(directory); //Klasör var mı diye bakar
            //                string[] directories = Directory.GetDirectories(directory); //Klasördeki klasörleri getirir
            //                string[] files = Directory.GetFiles(directory); //Klasördeki dosyaları getirir
            //                Directory.Move(""C:\\Folder"", ""C:\\Folder2""); //Klasörü ve içindekileri taşır, ismini değiştirir
            //                Directory.Delete(directory); //Boş klasörü siler

            //                File.Create(file); //Dosya oluşturur
            //                bool isFileExists = File.Exists(file); //Dosya var mı diye bakar
            //                File.Move(""C:\\Folder\\File.txt"", ""C:\\Folder\\File2.txt""); //Dosyayı taşır, ismini değiştirir
            //                File.Delete(file); //Dosyayı siler
            //            }
            //DirectoryInfo ve FileInfo Sınıfları
            //Directory ve File sınıfları klasör ve dosyalar üzerinde işlemler yaparken sadece dosya yolunu kullanırlar ve örneğin bir klasördeki tüm dosyaları getiren metodu çağırdığınızda size sadece dosyaların yollarını döndürür. DirectoryInfo ve FileInfo sınıfları ise, dosya yolunun haricinde dosya adı, uzantısı, boyutu, oluşturulma zamanı gibi ekstra bilgiler verir. Bu iki sınıf statik değildir ve bir obje üzerinden erişilebilir. Aşağıdaki örneklere bakabilirsiniz:
            //";
            //            File.WriteAllText("C:/Users/lenovo/source/metin2.txt", metin);

            //using (StreamWriter dosya = new ("C:/Users/lenovo/source/metin2.txt"))
            //{
            //    dosya.WriteLine("Merhaba, Dosya!");
            //    dosya.WriteLine("Bu metin bir C# programı tarafından dosyaya yazdırılmiştır.");
            //}


            //StreamWriter dosya = new StreamWriter("C:/Users/lenovo/source/metin2.txt");
            //dosya.WriteLine("Merhaba, Dosya!");
            //dosya.WriteLine("Bu metin bir C# programı tarafından dosyaya yazdırılmiştır.");
            //dosya.Close();
            //dosya.Dispose();
        }
    }
}
