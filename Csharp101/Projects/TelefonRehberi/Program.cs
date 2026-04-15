namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {

            Rehber telefonRehberi = new Rehber();
            Console.WriteLine("Console Telefon Rehberi Uygulamasina Hos Geldiniz...");

            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayi Silmek");
            Console.WriteLine("(3) Varolan Numarayi Guncelleme");
            Console.WriteLine("(4) Rehberi Listelemek ");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Listede Yer Alan Islemlerden Hangisini Yapmak Isterdiniz? (Yapmak Istediginiz Islemin Numarasini Giriniz)");
            int islemNumarasi = int.Parse(Console.ReadLine());
            Console.WriteLine("*******************************************");

            switch (islemNumarasi)
            {
                case 1:
                    Console.WriteLine("Secilen Islem: (1) Yeni Numara Kaydetmek");
                    telefonRehberi.KisiEkle();
                    break;
                case 2:
                    Console.WriteLine("Secilen Islem: (2) Varolan Numarayi Silmek");
                    telefonRehberi.KisiSil();
                    break;
                case 3:
                    Console.WriteLine("Secilen Islem: (3) Varolan Numarayi Guncelleme");
                    telefonRehberi.KisiGuncelle();
                    break;
                case 4:
                    Console.WriteLine("Secilen Islem: (4) Rehberi Listelemek ");
                    telefonRehberi.KisiListele();
                    break;
                case 5:
                    Console.WriteLine("Secilen Islem: (5) Rehberde Arama Yapmak");
                    telefonRehberi.RehberdeAra();
                    break;
            }

        }
    }

}

