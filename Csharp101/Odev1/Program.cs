using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- C# Algoritma Ödevleri ---");
        Console.WriteLine("1. Çift Sayıları Listele");
        Console.WriteLine("2. m'e Eşit veya Tam Bölünenleri Listele");
        Console.WriteLine("3. Kelimeleri Sondan Başa Yazdır");
        Console.WriteLine("4. Cümledeki Kelime ve Harf Sayısını Bul");
        Console.Write("\nÇalıştırmak istediğiniz ödev numarasını seçin (1-4): ");
        
        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                Odev1();
                break;
            case "2":
                Odev2();
                break;
            case "3":
                Odev3();
                break;
            case "4":
                Odev4();
                break;
            default:
                Console.WriteLine("Geçersiz seçim!");
                break;
        }
    }

    static void Odev1()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());
        int[] sayilar = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSonuç (Çift Sayılar):");
        foreach (var sayi in sayilar)
        {
            if (sayi % 2 == 0) Console.WriteLine(sayi);
        }
    }

    static void Odev2()
    {
        Console.Write("Kaç adet sayı gireceksiniz (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Bölünecek sayıyı girin (m): ");
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            int girilen = int.Parse(Console.ReadLine());
            if (girilen == m || girilen % m == 0)
                Console.WriteLine($"-> {girilen} kriteri sağlıyor.");
        }
    }

    static void Odev3()
    {
        Console.Write("Kaç adet kelime gireceksiniz (n): ");
        int n = int.Parse(Console.ReadLine());
        string[] kelimeler = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. kelimeyi girin: ");
            kelimeler[i] = Console.ReadLine();
        }

        Array.Reverse(kelimeler); // Diziyi tersine çevirir
        Console.WriteLine("\nSondan Başa Kelimeler:");
        foreach (var kelime in kelimeler) Console.WriteLine(kelime);
    }

    static void Odev4()
    {
        Console.Write("Bir cümle yazın: ");
        string cumle = Console.ReadLine();

        string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int harfSayisi = cumle.Replace(" ", "").Length;

        Console.WriteLine($"Toplam Kelime Sayısı: {kelimeler.Length}");
        Console.WriteLine($"Toplam Harf Sayısı: {harfSayisi}");
    }
}
