using System;

namespace IfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 11)
              Console.WriteLine("Günaydın");
            else if (time <= 18)
              Console.WriteLine("İyi Günler");
            else
              Console.WriteLine("İyi Geceler");

            string sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler"; // Ternary if-else
            Console.WriteLine("ternary: " + sonuc);
        }
    }
}

