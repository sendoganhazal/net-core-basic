
namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Ogrenci 1 ***");
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Ad = "İlkkan";
            ogrenci1.Soyad = "Yedinci";
            ogrenci1.OgrenciNo = 0505100089;
            ogrenci1.Sinif = 3;

            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("*** Ogrenci 2 ***");
            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Ad = "Cagatay";
            ogrenci2.Soyad = "Yilmaz";
            ogrenci2.OgrenciNo = 0505100100;
            ogrenci2.Sinif = 3;

            ogrenci2.OgrenciBilgileriniGetir();

            Console.WriteLine("*** Ogrenci 3 ***");
            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.Ad = "Ersoy";
            ogrenci3.Soyad = "Yamyamolduren";
            ogrenci3.OgrenciNo = 0505100100;
            ogrenci3.Sinif = 3;

            ogrenci3.OgrenciBilgileriniGetir();

            ogrenci3.SinifAtlat();
            ogrenci3.OgrenciBilgileriniGetir();

             Console.WriteLine("*** Ogrenci 4 ***");
            Ogrenci ogrenci4 = new Ogrenci("Hazal","Sendogan",0505100028,1);
            ogrenci4.OgrenciBilgileriniGetir();

            ogrenci4.SinifDusur();
            ogrenci4.OgrenciBilgileriniGetir();
        }
        class Ogrenci
        {
            private string ad;
            private string soyad;
            private int ogrenciNo;
            private int sinif;

            public string Ad { get => ad; set => ad = value; }
            public string Soyad { get => soyad; set => soyad = value; }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
            public int Sinif
            {
                get => sinif;
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("Sinif En Az 1 Olmalidir");
                        sinif = 1;
                    }
                    else
                    {
                        sinif = value;
                    }
                    
                }
            }

            public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
            {
                Ad = ad;
                Soyad = soyad;
                OgrenciNo = ogrenciNo;
                Sinif = sinif;
            }

            public Ogrenci() { }

            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("**** Ogrenci Bilgileri ****");
                Console.WriteLine($"Ogrenci Adi: \t\t {this.Ad}");
                Console.WriteLine($"Ogrenci Soyadi: \t {this.Soyad}");
                Console.WriteLine($"Ogrenci Numarasi: \t {this.OgrenciNo}");
                Console.WriteLine($"Ogrencinin Sinifi: \t {this.Sinif}");
            }

            public void SinifAtlat()
            {
                this.Sinif = this.sinif + 1;
            }
            public void SinifDusur()
            {
                this.Sinif = this.sinif - 1;
            }
        }
    }
}



;