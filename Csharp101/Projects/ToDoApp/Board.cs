using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoApp
{
    public class Board
    {
        public List<Kart> Kartlar = new List<Kart>();
        Takim takim = new Takim();

        public Board()
        {
            // default kartlar
            Kartlar.Add(new Kart { Baslik="Task1", Icerik="Deneme", KisiId=1, Boyut=Buyukluk.M, Line="TODO" });
            Kartlar.Add(new Kart { Baslik="Task2", Icerik="Deneme", KisiId=2, Boyut=Buyukluk.L, Line="IN PROGRESS" });
            Kartlar.Add(new Kart { Baslik="Task3", Icerik="Deneme", KisiId=3, Boyut=Buyukluk.S, Line="DONE" });
        }

        public void Listele()
        {
            string[] lines = { "TODO", "IN PROGRESS", "DONE" };

            foreach (var line in lines)
            {
                Console.WriteLine(line + " Line");
                Console.WriteLine("*******************");

                var filtre = Kartlar.Where(x => x.Line == line).ToList();

                if (filtre.Count == 0)
                {
                    Console.WriteLine("~ BOŞ ~");
                }

                foreach (var kart in filtre)
                {
                    Console.WriteLine($"Başlık: {kart.Baslik}");
                    Console.WriteLine($"İçerik: {kart.Icerik}");
                    Console.WriteLine($"Atanan: {takim.Uyeler[kart.KisiId]}");
                    Console.WriteLine($"Büyüklük: {kart.Boyut}");
                    Console.WriteLine("-");
                }
            }
        }

        public void KartEkle()
        {
            Kart kart = new Kart();

            Console.Write("Başlık: ");
            kart.Baslik = Console.ReadLine();

            Console.Write("İçerik: ");
            kart.Icerik = Console.ReadLine();

            Console.Write("Büyüklük (1-5): ");
            kart.Boyut = (Buyukluk)int.Parse(Console.ReadLine());

            Console.Write("Kişi ID (1-3): ");
            int kisiId = int.Parse(Console.ReadLine());

            if (!takim.Uyeler.ContainsKey(kisiId))
            {
                Console.WriteLine("Hatalı giriş!");
                return;
            }

            kart.KisiId = kisiId;
            kart.Line = "TODO";

            Kartlar.Add(kart);
            Console.WriteLine("Kart eklendi!");
        }

        public void KartSil()
        {
            Console.Write("Başlık gir: ");
            string baslik = Console.ReadLine();

            var silinecek = Kartlar.Where(x => x.Baslik == baslik).ToList();

            if (silinecek.Count == 0)
            {
                Console.WriteLine("Kart bulunamadı!");
                return;
            }

            foreach (var kart in silinecek)
            {
                Kartlar.Remove(kart);
            }

            Console.WriteLine("Kart silindi!");
        }

        public void KartTasi()
        {
            Console.Write("Başlık gir: ");
            string baslik = Console.ReadLine();

            var kart = Kartlar.FirstOrDefault(x => x.Baslik == baslik);

            if (kart == null)
            {
                Console.WriteLine("Kart bulunamadı!");
                return;
            }

            Console.WriteLine($"Başlık: {kart.Baslik}");
            Console.WriteLine($"Line: {kart.Line}");

            Console.WriteLine("Yeni line seç: (1) TODO (2) IN PROGRESS (3) DONE");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    kart.Line = "TODO";
                    break;
                case "2":
                    kart.Line = "IN PROGRESS";
                    break;
                case "3":
                    kart.Line = "DONE";
                    break;
                default:
                    Console.WriteLine("Hatalı seçim!");
                    return;
            }

            Console.WriteLine("Kart taşındı!");
        }
    }
}