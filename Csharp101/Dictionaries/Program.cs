using System.Collections;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Ayse Yilmaz");
            kullanicilar.Add(12, "Ahmet Yilmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Ozcan Cosar");
            // kullanicilar.Add(12, "Ahmet Yilmaz"); // Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: 12

            //Dizinin elemanına erişim
            Console.WriteLine("***** Elemanlara erişim *****");

            Console.WriteLine(kullanicilar[12]);

            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici);
            }

            //Count

            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanicilar.Count);

            //Contains

            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanicilar.ContainsKey(20));
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            //Remove 
            Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(12);
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici);
            }

            //Keys
            Console.WriteLine("***** Keys *****");
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici.Key);
            }

            //Values

            Console.WriteLine("***** Values *****");
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici.Value);
            }
        }
    }
}




