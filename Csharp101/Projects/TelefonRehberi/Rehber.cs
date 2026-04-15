namespace TelefonRehberi
{
    public class Rehber
    {
        List<Kisi> KisiListesi = new List<Kisi>();
        public Rehber()
        {
            KisiListesi.AddRange(new List<Kisi>{
            new Kisi("Çağatay", "Yılmaz", "05991234567"),
            new Kisi("İlkkan", "Yedinci", "05994567890"),
            new Kisi("Ersoy", "Yamyamolduren", "05990987654"),
            new Kisi("Etem", "Dokuzcanlı", "05990123456"),
            new Kisi("Sahibe Seher", "Otuzaltıbin", "05996516840"),
            });
        }
        public void KisiEkle()
        {
            Console.WriteLine("Lutfen isim giriniz: ");
            string ad = Console.ReadLine();
            ad = ad.ToLower();
            Console.WriteLine("Lutfen soyisim giriniz: ");
            string soyad = Console.ReadLine();
            soyad = soyad.ToLower();
            Console.WriteLine("Lutfen telefon numarasi giriniz: ");
            string numara = Console.ReadLine();

            KisiListesi.Add(new Kisi(ad, soyad, numara));
            Console.WriteLine($"{ad} {soyad} kisisi basariyla eklendi :)");
        }

        public void KisiSil()
        {
            Console.WriteLine("Lutfen numarasini silmek istediğiniz kisinin adini ya da soyadini giriniz: ");
            string terim = Console.ReadLine().ToLower();
            bool silindiMi = false;


            Kisi silinecekKisi = KisiListesi.FirstOrDefault(kisi =>
            kisi.Ad.ToLower() == terim || kisi.Soyad.ToLower() == terim);
            if (silinecekKisi != null)
            {
                Console.WriteLine($"{silinecekKisi.Ad} {silinecekKisi.Soyad} isimli kisi rehberden silinmek uzere, onayliyor musunuz ?(y/n)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Islem Iptal Edildi");
                    return;
                }
                else
                {
                    KisiListesi.Remove(silinecekKisi);
                    silindiMi = true;
                }
            }
            if (silindiMi)
            {
                Console.WriteLine($"{terim} basariyla silindi :)");
            }
            else
            {
                Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi...");
                Console.WriteLine("Lutfen Bir Secim Yapiniz.");
                Console.WriteLine("*******************************************");
                Console.WriteLine("Guncellemeyi sonlandirmak için    : (1)");
                Console.WriteLine("Yeniden denemek için              : (2)");
                Console.WriteLine("*******************************************");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        KisiSil();
                        break;
                    default:
                        Console.WriteLine("Hatali Secim Yaptiniz.");
                        break;
                }
            }
        }
        public void KisiGuncelle()
        {
            Console.WriteLine("Lutfen numarasini guncellemek istediğiniz kisinin adini ya da soyadini giriniz:  ");
            string terim = Console.ReadLine().ToLower();
            bool guncellendiMi = false;
            Kisi guncellenecekKisi = KisiListesi.FirstOrDefault(kisi =>
                kisi.Ad.ToLower() == terim || kisi.Soyad.ToLower() == terim);

            if (guncellenecekKisi != null)
            {
                Console.WriteLine("Lutfen guncellemek istediginiz bilgiyi seçiniz: ");
                Console.WriteLine("(1) Ad");
                Console.WriteLine("(2) Soyad");
                Console.WriteLine("(3) Telefon Numarasi");

                int value = int.Parse(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        Console.WriteLine("Lutfen yeni ad giriniz: ");
                        string yeniAd = Console.ReadLine().ToLower();
                        guncellenecekKisi.Ad = yeniAd;
                        guncellendiMi = true;
                        break;
                    case 2:
                        Console.WriteLine("Lütfen yeni soyad giriniz: ");
                        string yeniSoyad = Console.ReadLine().ToLower();
                        guncellenecekKisi.Soyad = yeniSoyad;
                        guncellendiMi = true;
                        break;
                    case 3:
                        Console.WriteLine("Lutfen yeni telefon numarasi giriniz: ");
                        string yeniNumara = Console.ReadLine();
                        guncellenecekKisi.TelNo = yeniNumara;
                        guncellendiMi = true;
                        break;
                    default:
                        Console.WriteLine("Hatali secim yaptiniz.");
                        break;
                }
            }
            if (guncellendiMi)
            {
                Console.WriteLine($"{terim} basariyla guncellendi :)");
            }
            else
            {
                Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi...");
                Console.WriteLine("Lutfen Bir Secim Yapiniz.");
                Console.WriteLine("*******************************************");
                Console.WriteLine("Guncellemeyi sonlandirmak için    : (1)");
                Console.WriteLine("Yeniden denemek için              : (2)");
                Console.WriteLine("*******************************************");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        KisiGuncelle();
                        break;
                    default:
                        Console.WriteLine("Hatali secim yaptiniz.");
                        break;
                }
            }

        }

        public void KisiListele()
        {
            Console.WriteLine("Lutfen Bir Listeleme Turu Seciniz ");
            Console.WriteLine("(1) A-Z");
            Console.WriteLine("(2) Z-A");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    KisiListesi = KisiListesi.OrderBy(kisi => kisi.Ad).ToList();
                    break;
                case 2:
                    KisiListesi = KisiListesi.OrderByDescending(kisi => kisi.Ad).ToList();
                    break;
                default:
                    Console.WriteLine("Hatali seçim yaptiniz.");
                    break;
            }

            Console.WriteLine("*******************************************");
            Console.WriteLine("Telefon Rehberi");
            foreach (var kisi in KisiListesi)
            {

                Console.WriteLine($"Ad: {kisi.Ad}");
                Console.WriteLine($"Soyad: {kisi.Soyad}");
                Console.WriteLine($"Numara: {kisi.TelNo}");
            }
            Console.WriteLine("*******************************************");
        }

        public void RehberdeAra()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("İsim veya soyisime gore arama yapmak icin (1)");
            Console.WriteLine("Telefon numarasina gore arama yapmak icin: (2)");
            int tip = int.Parse(Console.ReadLine());

            bool bulunduMu = false;
            if (tip == 1)
            {
                Console.WriteLine("Lutfen aranacak kisinin ismini ya da soyismini girin");
            }
            else if (tip == 2)
            {
                Console.WriteLine("Lutfen aranacak kisinin numarasini girin");
            }
            string terim = Console.ReadLine().ToLower();
            Console.WriteLine("*******************************************");
            Console.WriteLine("Arama Sonucu");
            foreach (Kisi kisi in KisiListesi)
            {
                if (kisi.Ad.ToLower().Contains(terim) || kisi.Soyad.ToLower().Contains(terim) || kisi.TelNo.ToLower().Contains(terim))
                {
                    Console.WriteLine("---");
                    Console.WriteLine($"Ad: {kisi.Ad}");
                    Console.WriteLine($"Soyad: {kisi.Soyad}");
                    Console.WriteLine($"Numara: {kisi.TelNo}");
                    bulunduMu = true;

                }

            }
            if (!bulunduMu)
            {
                Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi...");
                Console.WriteLine("Lutfen Bir Secim Yapiniz.");
                Console.WriteLine("*******************************************");
                Console.WriteLine("Guncellemeyi sonlandirmak için    : (1)");
                Console.WriteLine("Yeniden denemek için              : (2)");
                Console.WriteLine("*******************************************");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        RehberdeAra();
                        break;
                    default:
                        Console.WriteLine("Hatali secim yaptiniz.");
                        break;
                }
            }
            Console.WriteLine("*******************************************");


        }
    }

}
