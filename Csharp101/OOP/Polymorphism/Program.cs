namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Tohumlu Bitkiler ***");
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("*** Tohumsuz Bitkiler ***");
            TohumsuzBitkiler tohumsuzBitkiler = new TohumsuzBitkiler();
            tohumsuzBitkiler.SporlaCogalma();

            Console.WriteLine("*** Martilar ***");
            Kuslar martilar = new Kuslar();
            martilar.Hareket();

            Console.WriteLine("*** Yilanlar ***");
            Surungenler yilan = new Surungenler();
            yilan.Hareket();
        }
    }

}

