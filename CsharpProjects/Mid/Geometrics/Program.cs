using System;

namespace Geometrics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometrik şekil seçiniz (Daire, Ucgen, Kare, Dikdortgen): ");
            string sekil = Console.ReadLine().ToLower();

            Console.WriteLine("Hesap (Alan / Cevre): ");
            string boyut = Console.ReadLine().ToLower();

            switch (sekil)
            {
                case "daire":
                    Console.WriteLine("Yaricap:");
                    int r = int.Parse(Console.ReadLine());
                    Daire(r, boyut);
                    break;

                case "ucgen":
                    Console.WriteLine("3 kenar gir:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    Ucgen(a, b, c, boyut);
                    break;

                case "kare":
                    Console.WriteLine("Kenar:");
                    int k = int.Parse(Console.ReadLine());
                    Kare(k, boyut);
                    break;

                case "dikdortgen":
                    Console.WriteLine("Kısa kenar:");
                    int kk = int.Parse(Console.ReadLine());
                    Console.WriteLine("Uzun kenar:");
                    int uk = int.Parse(Console.ReadLine());
                    Dikdortgen(kk, uk, boyut);
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void Daire(int yaricap, string boyut)
        {
            if (boyut == "alan")
            {
                double alan = Math.PI * yaricap * yaricap;
                Console.WriteLine("Dairenin Alanı = " + alan);
            }
            else if (boyut == "cevre")
            {
                double cevre = 2 * Math.PI * yaricap;
                Console.WriteLine("Dairenin Çevresi = " + cevre);
            }
        }

        public static void Kare(int kenar, string boyut)
        {
            if (boyut == "alan")
            {
                Console.WriteLine("Karenin Alanı = " + (kenar * kenar));
            }
            else if (boyut == "cevre")
            {
                Console.WriteLine("Karenin Çevresi = " + (4 * kenar));
            }
        }

        public static void Dikdortgen(int kisaKenar, int uzunKenar, string boyut)
        {
            if (boyut == "alan")
            {
                Console.WriteLine("Dikdörtgen Alanı = " + (kisaKenar * uzunKenar));
            }
            else if (boyut == "cevre")
            {
                Console.WriteLine("Dikdörtgen Çevresi = " + (2 * (kisaKenar + uzunKenar)));
            }
        }

        public static void Ucgen(int kenar1, int kenar2, int kenar3, string boyut)
        {
            int cevre = kenar1 + kenar2 + kenar3;

            if (boyut == "alan")
            {
                double s = cevre / 2.0;
                double alan = Math.Sqrt(s * (s - kenar1) * (s - kenar2) * (s - kenar3));

                Console.WriteLine("Üçgen Alanı = " + alan);
            }
            else if (boyut == "cevre")
            {
                Console.WriteLine("Üçgen Çevresi = " + cevre);
            }
        }
    }
}