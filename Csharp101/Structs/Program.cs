namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(); //classlarda new ile nesnesini yaratmak zorunlu

            dikdortgen.KisaKenar = 12;
            dikdortgen.UzunKenar = 16;

            long classAlan = dikdortgen.AlanHesapla();

            Console.WriteLine("Class ile Hesaplanan Alan {0}", classAlan);

            Dikdortgen_Struct dikdortgenStruct; // strucları new ile yaratmadan da yapabiliyoruz.

            dikdortgenStruct.KisaKenar = 15;
            dikdortgenStruct.UzunKenar = 20;

            long structAlan = dikdortgenStruct.AlanHesapla();

            Console.WriteLine("Struct ile Hesaplanan Alan {0}", structAlan);
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
