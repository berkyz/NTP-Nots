namespace Ders06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[4];
            //int[] b = new int[4] { 1, 4, 9, 16 };
            //int[] c = new int[] { 1, 4, 9, 16 };
            //int[] d = { 1, 4, 9, 16 };
            //int[] e = [1, 4, 9, 16];

            //var f = new int[]{ 1, 4, 9, 16 };

            //double[,] mat = new double[5, 8];
            //double[,] matris = { 
            //                     { 1, 0, 0, 0, 0},
            //                     { 0, 1, 0, 0, 0},
            //                     { 0, 0, 0,-1, 0},
            //                   };

            //double[,,] kkor = new double[10, 10, 10];

            //Console.Write("N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] sayilar = new double[n];
            //double test = double.MinValue;


            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write("{0}. SAYI: ", i + 1);
            //    sayilar[i] = Convert.ToDouble(Console.ReadLine());
            //    if(test < sayilar[i])
            //        test = sayilar[i];
            //}

            ////test = sayilar[0];
            ////for(int i = 1; i < sayilar.Length; i++)
            ////{
            ////    if(test < sayilar[i])
            ////    {
            ////        test = sayilar[i];
            ////    }
            ////}

            //Console.WriteLine("En büyük: " +test );

            int[] notlar = [90, 60, 70, 80, 80];
            double ortalama = notlar.Average();
            // double ortalama = (double)notlar.Sum() / notlar.Length;

            int gs = 0;

            foreach(int notum in notlar)
                if(notum >= ortalama)
                    gs++;

            Console.WriteLine("Geçenlerin sayısı: "+gs);

        }
    }
}
