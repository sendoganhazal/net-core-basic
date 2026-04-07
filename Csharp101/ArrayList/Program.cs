using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            ArrayList liste = new ArrayList();
            // liste.Add("Hazal");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            //itemlara erişim
            // Console.WriteLine("1. eleman: " + liste[1]);
            // foreach (var item in liste)
            // {
            //     Console.WriteLine("*" + " " + item);
            // }

            //Addrange birden fazla elemanı toplu ekleme
            Console.WriteLine("***** Add Range*****");

            string[] renkler = { "Sari", "Lacivert", "Yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };

            liste.AddRange(sayilar);
            // liste.AddRange(renkler);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("*****Sort*****");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Binary Search*****");
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Clear *****");
            liste.Clear();
            Console.WriteLine(liste.Count);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}



