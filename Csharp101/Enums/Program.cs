namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sicaklik = 32;

            if (sicaklik < (int)HavaSicakligi.Normal)
            {
                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim");
            }
            else if (sicaklik >= (int)HavaSicakligi.Sicak)
            {
                Console.WriteLine("Disariya cikmak icin cok sicak bir gun");
            }
            else if (sicaklik >= (int)HavaSicakligi.Normal && sicaklik < (int)HavaSicakligi.CokSicak)
            {
                Console.WriteLine("Hadi disariya cikalim");
            }
        }
        enum Gunler
        {
            Pazartesi = 1,
            Sali,
            Carsamba,
            Persembe,
            Cuma = 23,
            Cumartesi,
            Pazar
        }
        enum HavaSicakligi
        {
            Soguk = 5,
            Normal = 20,
            Sicak = 25,
            CokSicak = 30
        }
    }
}

