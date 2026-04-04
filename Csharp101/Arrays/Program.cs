using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //** Array tanımlama
            Console.WriteLine("***** Array Tanımlama *****");
            DefineArray();

        }
        public static void DefineArray()
        {
            //** Defining arrays
            string[] colors = new string[5];
            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

            int[] arr;
            arr = new int[5];

            // adding values to array and accessing them
            colors[0] = "Red";
            Console.WriteLine(animals[1]);
            arr[3] = 10;
            Console.WriteLine(colors[0]);
            Console.WriteLine(arr[3]);

            //using for loop to access array elements
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayisini giriniz:");
            int diziUzunluk = int.Parse(Console.ReadLine());
            int[] sayiDizi = new int[diziUzunluk];

            for (int i = 0; i < diziUzunluk; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı giriniz:");
                sayiDizi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (int sayi in sayiDizi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama:" + "" + toplam / diziUzunluk);
        }
    }
}


