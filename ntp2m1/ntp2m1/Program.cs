namespace ntp2m1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosya dosya = new Dosya();
            dosya.PropertyChanged += file_PropertyChanged;

            dosya.Filename = "merhaba.txt";
            dosya.Filename = "yineMerhaba.txt";
        }

        private static void file_PropertyChanged(object sender, BildirEventArgs e)
        {
            Console.WriteLine(@$"
+-----------------------------------------------+
                 Dikkat                       
                                              
        DEĞİŞEN ÖZELLİK:  {e.PropertyName}
        Eski Değeri    :  {e.OldValue}
        Yeni Değeri    :  {e.NewValue}

+-----------------------------------------------+
");
        }
    }
}
