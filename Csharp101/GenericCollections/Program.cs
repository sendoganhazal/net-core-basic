namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //Generic Collections
            Generics();
        }

        public static void Generics()
        {
            //List<T> class
            //System.Collection.Generic
            // T-> object türünde

            List<int> sayiList = new List<int>();
            sayiList.Add(23);
            sayiList.Add(10);
            sayiList.Add(4);
            sayiList.Add(5);
            sayiList.Add(92);
            sayiList.Add(34);

            List<string> renkList = new List<string>();
            renkList.Add("Kirmizi");
            renkList.Add("Mavi");
            renkList.Add("Turuncu");
            renkList.Add("Sari");
            renkList.Add("Yeşil");

            //Count
            Console.WriteLine($"Renk Listesi eleman sayisi {renkList.Count}");
            Console.WriteLine($"Sayi Listesi eleman sayisi {sayiList.Count}");

            //elemanlari ekrana yazdirma

            foreach (var sayi in sayiList)
            {
                Console.WriteLine($"sayi: {sayi}");
            }
            foreach (var renk in renkList)
            {
                Console.WriteLine($"renk: {renk}");
            }
            sayiList.ForEach(sayi => Console.WriteLine($"2. sayi: {sayi}"));
            renkList.ForEach(renk => Console.WriteLine($"2. renk: {renk}"));

            //Listeden eleman çıkarma
            sayiList.Remove(4);
            renkList.Remove("Yeşil");
            sayiList.ForEach(sayi => Console.WriteLine($"sayi: {sayi}"));
            renkList.ForEach(renk => Console.WriteLine($"renk: {renk}"));

            sayiList.RemoveAt(0);//indexe göre
            renkList.RemoveAt(2);
            sayiList.ForEach(sayi => Console.WriteLine($"sayi: {sayi}"));
            renkList.ForEach(renk => Console.WriteLine($"renk: {renk}"));

            //Liste içinde arama
            if (sayiList.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu");
            }

            //eleman ile indexe erişme
            Console.WriteLine(renkList.BinarySearch("Sari"));

            //Diziyi Liste Çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListe = new List<string>(hayvanlar);

            //Tüm diziyi temizleme
            hayvanListe.Clear();
            Console.WriteLine(hayvanListe.Count);

            //List içinde nesne
            List<Kullanicilar> kullaniciListe = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Hazal";
            kullanici1.SoyIsim = "Şendoğan";
            kullanici1.Yas = 34;
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Nazli";
            kullanici2.SoyIsim = "Yildirim";
            kullanici2.Yas = 31;

            kullaniciListe.Add(kullanici1);
            kullaniciListe.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Hazal",
                SoyIsim = "Şendoğan",
                Yas = 34
            }
            );

            foreach (var kullanici in kullaniciListe)
            {
                Console.WriteLine($"{kullanici.Isim} {kullanici.SoyIsim} - {kullanici.Yas}");
            }
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}


