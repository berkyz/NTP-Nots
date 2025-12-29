using System.Text; 


namespace Ders10e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "C:/Users/lenovo/source/metin.txt";
            try
            {
                using (StreamReader dosya = new StreamReader(dosyaYolu))
                {
                    char satir;
                    while ((satir = (char)dosya.Read()) != '\xFFFF')
                        Console.Write(satir);
                }
            }
            catch(FileNotFoundException hata)
            {
                Console.WriteLine("Dosya bulunamadı. \r\n"+hata.Message);
            }

            //string[] satirlar = File.ReadAllLines(dosyaYolu);
            //foreach (string s in satirlar)
            //    Console.WriteLine(s);

            // Console.WriteLine(File.ReadAllText(dosyaYolu));

            //// using (StreamReader dosya = new(dosyaYolu))
            //// using (var dosya = new StreamReader(dosyaYolu))
            //using (StreamReader dosya = new StreamReader(dosyaYolu))
            //{
            //    string satir = "";
            //    while ((satir = dosya.ReadLine()) != null)
            //        Console.WriteLine(satir);
            //}

            //StreamReader dosya = new StreamReader(@"C:/Users/lenovo/source/repos/NTP/Ders10e/Ders10e/bin/Debug/net9.0/adlar.txt");
            //string satir = "";
            //while((satir = dosya.ReadLine()) != null)
            //    Console.WriteLine(satir);
            //dosya.Close();
            //dosya.Dispose();
        }
    }
}
