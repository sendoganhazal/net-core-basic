namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //** For Loop
            Console.WriteLine("***** For Loop *****");
            ForLoop();
            //** Break
            Console.WriteLine("***** Break *****");
            Break();
            //** Continue
            Console.WriteLine("***** Continue *****");
            Continue();
        }
        public static void ForLoop()
        {
            // 0'dan console'dan girilen sayıya kadar olan tek sayıları ekrana yazdıran bir for döngüsü yazınız.
            Console.Write("Lütfen Bir Sayi Giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (var i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            //1'den 1000'e kadar olan sayılardan teklerin ve çiftlerin kendi içlerindeki toplamını ekrana yazdıran bir for döngüsü yazınız.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (var i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i; //teklerin kendi içlerindeki toplamı
                else
                    ciftToplam += i; //çiftlerin kendi içlerindeki toplamı

            }
            Console.WriteLine("Teklerin Toplami: " + tekToplam);
            Console.WriteLine("Ciftlerin Toplami: " + ciftToplam);
        }

        public static void Break()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i == 4)
                    break; //i 4'e eşit olduğunda döngüyü kırar ve döngüden çıkar.
                Console.WriteLine(i);
            }

        }

        public static void Continue()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue; //i 4'e eşit olduğunda o adımı atlar ve döngünün bir sonraki adımına geçer.
                Console.WriteLine(i);
            }
        }
    }
}



