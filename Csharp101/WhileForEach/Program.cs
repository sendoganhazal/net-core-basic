namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //** While
            Console.WriteLine("***** While *****");
            While();
            //**Foreach
            Console.WriteLine("***** ForEach*****");
            ForEach();
        }

        public static void While()
        {
            // birden başlayarak consoledan girilen sayıya kadar (sayı dahil) ort hesaplayarak ekrana yazdıran bir while döngüsü
            Console.Write("Lütfen Bir Sayi Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalam: " + toplam / sayi);
            // a'dan z'ye kadar olan harfleri ekrana yazdıran bir while döngüsü
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character + " ");
                character++;
            }
            Console.WriteLine(" ");
        }

        public static void ForEach()
        {
            string[] arabalar = { "BMW", "Mercedes", "Ford", "Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine($"Araba: {araba}");
            }
        }
    }
}




