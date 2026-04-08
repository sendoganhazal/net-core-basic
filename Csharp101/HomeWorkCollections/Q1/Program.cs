using System;
using System.Collections;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int number;
            int flag;

            float totalPrimeNumbers = 0;
            float totalNonPrimeNumbers = 0;

            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();

            for (int i = 0; i < x; i++)
            {
                Console.Write("Lütfen değer giriniz: ");

                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Geçersiz giriş!");
                    i--;
                    continue;
                }

                if (number < 0)
                {
                    Console.WriteLine("Negatif sayı giremezsiniz!");
                    i--;
                    continue;
                }

                flag = 0;

                if (number == 1)
                    flag = 1;

                for (int j = 2; j < number; j++)
                {
                    if (number == 2)
                        break;

                    if (number % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 1)
                    nonPrimeNumbers.Add(number);
                else
                    primeNumbers.Add(number);
            }

            // Sorting
            primeNumbers.Sort();
            primeNumbers.Reverse();

            nonPrimeNumbers.Sort();
            nonPrimeNumbers.Reverse();

            Console.WriteLine("\n*** Prime Numbers ***");
            foreach (var item in primeNumbers)
            {
                Console.Write(item + " ");
                totalPrimeNumbers += Convert.ToInt32(item);
            }

            Console.WriteLine("\n*** Non-Prime Numbers ***");
            foreach (var item in nonPrimeNumbers)
            {
                Console.Write(item + " ");
                totalNonPrimeNumbers += Convert.ToInt32(item);
            }

            Console.WriteLine("\n\nAsal sayi adedi: " + primeNumbers.Count);
            Console.WriteLine("Asal ortalama: " + (primeNumbers.Count > 0 ? totalPrimeNumbers / primeNumbers.Count : 0));

            Console.WriteLine("\nAsal olmayan sayi adedi: " + nonPrimeNumbers.Count);
            Console.WriteLine("Asal olmayan ortalama: " + (nonPrimeNumbers.Count > 0 ? totalNonPrimeNumbers / nonPrimeNumbers.Count : 0));
        }
    }
}