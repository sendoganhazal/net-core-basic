namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Static Olmayan Class ****");
            Console.WriteLine("Calisan Sayisi {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("İlkkan", "Yedinci", "Halkla İlişkiler");
            Calisan calisan2 = new Calisan("Cagatay", "Yilmaz", "Yonetim");
            Calisan calisan3 = new Calisan("Ersoy", "Yamyamolduren", "Muhasebe");

            Console.WriteLine("**** Static  Class ****");
            Console.WriteLine("Toplama İslemi Sonucu {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Cikarma İslemi Sonucu {0}", Islemler.Cikar(400, 50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi
        {
            get => calisanSayisi;
        }
        public string Ad;
        public string Soyad;
        public string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string ad, string soyad, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Departman = departman;
            calisanSayisi++;

            Console.WriteLine("\n*** Calisan Atandi ***");
            Console.WriteLine("Calisan Adi {0}", this.Ad);
            Console.WriteLine("Calisan Soyadi {0}", this.Soyad);
            Console.WriteLine("Calisan Departmani {0}", this.Departman);
            Console.WriteLine("Calisan Sayisi {0}", calisanSayisi);
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
