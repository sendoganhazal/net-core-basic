using System;
using System.Linq;

namespace IntegerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayilari boslukla giriniz:");

            int[] sayilar = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            int kucukToplam = 0;
            int buyukToplam = 0;

            foreach (var sayi in sayilar)
            {
                if (sayi < 67)
                {
                    int fark = 67 - sayi;
                    kucukToplam += fark;
                }
                else if (sayi > 67)
                {
                    int fark = sayi - 67;
                    buyukToplam += fark * fark; // kare
                }
            }

            Console.WriteLine($"{kucukToplam} {buyukToplam}");
        }
    }
}