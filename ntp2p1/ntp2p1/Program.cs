using System.Collections;
namespace ntp2p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kuyruk FIFO/ First In First Out
            Queue kuyruk = new Queue();
            kuyruk.Enqueue("Abdülselam");
            kuyruk.Enqueue(3.85);
            kuyruk.Enqueue(true);
            kuyruk.Enqueue('A');

            string aranan = "Abdülselam";
            if (kuyruk.Contains(aranan))
            {
                Console.WriteLine($"Evet, {aranan} kuyrukta yer alıyor.");
            }
            else
            {
                Console.WriteLine($"Evet, {aranan} kuyrukta yer almıyor.");
            }

                foreach (var oge in kuyruk)
                    Console.WriteLine(oge);

            Console.WriteLine(kuyruk.Count);
            Console.WriteLine(kuyruk.Dequeue());
            Console.WriteLine(kuyruk.Count);

            Console.WriteLine(kuyruk.Peek());
            Console.WriteLine(kuyruk.Count);

        }
    }
}
