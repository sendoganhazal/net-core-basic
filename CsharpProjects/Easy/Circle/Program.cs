using System;

namespace CircleApp
{
    // Daireyi oluşturan sınıf (iş mantığı)
    class CircleBuilder
    {
        public string Build(int radius)
        {
            string result = "";

            for (int i = -radius; i <= radius; i++)
            {
                result += BuildLine(radius, i);
            }

            return result;
        }

        private string BuildLine(int radius, int y)
        {
            string line = "";

            for (int x = -radius; x <= radius; x++)
            {
                if (IsPointOnCircle(x, y, radius))
                    line += "*";
                else
                    line += " ";
            }

            line += "\n";
            return line;
        }

        private bool IsPointOnCircle(int x, int y, int radius)
        {
            // x^2 + y^2 <= r^2 (daire denklemi)
            return x * x + y * y <= radius * radius;
        }
    }

    // Ekrana yazdırma sorumluluğu
    class Printer
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daire yarıçapını giriniz: ");
            int radius = int.Parse(Console.ReadLine());

            CircleBuilder circleBuilder = new CircleBuilder();
            Printer printer = new Printer();

            string circle = circleBuilder.Build(radius);
            printer.Print(circle);
        }
    }
}
