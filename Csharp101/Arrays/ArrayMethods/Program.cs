using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //** Array Sınıfı Metotları
            Console.WriteLine("***** Array Sınıfı Metotları *****");

            MethodsArray();

        }
        public static void MethodsArray()
        {
            // array sort 
            Console.WriteLine("*** Array Sort ***");
            int[] sayilar = { 23, 12, 86, 4, 76, 3, 11, 17 };

            Console.WriteLine("** Sirasiz Liste **");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine("Sayi" + " " + sayi);
            }
            Array.Sort(sayilar);
            Console.WriteLine("** Sirali Liste **");
            foreach (var sy in sayilar)
            {
                Console.WriteLine("Sayi" + " " + sy);
            }

            //array clear
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayilar, 2, 2); // sayilar dizisinin 2. indexinden itibaren 2 tane elemanını sıfırlar.
            foreach (var sayi in sayilar)
            {
                Console.WriteLine("Sayi" + " " + sayi);
            }

            //array reverse
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayilar); //sayilar dizisini ters çevirir.
            foreach (var sayi in sayilar)
            {
                Console.WriteLine("Sayi" + " " + sayi);
            }

            //indexof
            Console.WriteLine("*** Array Indexof ***");
            int index23 = Array.IndexOf(sayilar, 23); // sayilar dizisinde 23 sayısının indexini verir.
            Console.WriteLine("23 sayisinin indexi: " + index23);
            int index77 = Array.IndexOf(sayilar, 77); // sayilar dizisinde 77 sayısının indexini verir. Eğer sayı dizide yoksa -1 döner.
            Console.WriteLine("77 sayisinin indexi: " + index77);

            //resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayilar,9); // sayilar dizisinin boyutunu 9 yapar. Eğer yeni boyut eski boyuttan büyükse yeni elemanlar varsayılan değere sahip olur (int için 0).
            sayilar[8] = 99;
            foreach (var sayi in sayilar)
            {
                Console.WriteLine("Sayi" + " " + sayi);
            }
        }
    }
}



