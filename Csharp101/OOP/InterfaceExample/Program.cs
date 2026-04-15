namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Focus focus = new Focus();
            Console.WriteLine("==========");
            Console.WriteLine("Tekerlek Sayisi {0}", focus.TekerlekSayisi());
            Console.WriteLine("Aracin Markasi {0}", focus.AracinMarkasi().ToString());
            Console.WriteLine("Standart Renk {0}", focus.StandartRenk().ToString());

            Civic civic = new Civic();
            Console.WriteLine("==========");
            Console.WriteLine("Tekerlek Sayisi {0}", civic.TekerlekSayisi());
            Console.WriteLine("Aracin Markasi {0}", civic.AracinMarkasi().ToString());
            Console.WriteLine("Standart Renk {0}", civic.StandartRenk().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine("==========");
            Console.WriteLine("Tekerlek Sayisi {0}", corolla.TekerlekSayisi());
            Console.WriteLine("Aracin Markasi {0}", corolla.AracinMarkasi().ToString());
            Console.WriteLine("Standart Renk {0}", corolla.StandartRenk().ToString());

            Golf golf = new Golf();
            Console.WriteLine("==========");
            Console.WriteLine("Tekerlek Sayisi {0}", golf.TekerlekSayisi());
            Console.WriteLine("Aracin Markasi {0}", golf.AracinMarkasi().ToString());
            Console.WriteLine("Standart Renk {0}", golf.StandartRenk().ToString());
        }
    }

}


