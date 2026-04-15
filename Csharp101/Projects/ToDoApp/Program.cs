using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            while (true)
            {
                Console.WriteLine("\n1- Listele");
                Console.WriteLine("2- Kart Ekle");
                Console.WriteLine("3- Kart Sil");
                Console.WriteLine("4- Kart Taşı");
                Console.WriteLine("0- Çıkış");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        board.Listele();
                        break;
                    case "2":
                        board.KartEkle();
                        break;
                    case "3":
                        board.KartSil();
                        break;
                    case "4":
                        board.KartTasi();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Hatalı seçim!");
                        break;
                }
            }
        }
    }
}
