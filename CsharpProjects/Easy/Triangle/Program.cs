using System;

namespace TriangleApp
{
    // Üçgen oluşturma işlemi
    class TriangleBuilder
    {
        public string Build(int size)
        {
            string result = "";

            for (int i = 1; i <= size; i++)
            {
                result += BuildLine(i);
            }

            return result;
        }

        private string BuildLine(int starCount)
        {
            string line = "";

            for (int i = 0; i < starCount; i++)
            {
                line += "*";
            }

            line += "\n";
            return line;
        }
    }

    // Konsola yazdırma işlemi
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
            Console.Write("Üçgen boyutunu giriniz: ");
            int size = int.Parse(Console.ReadLine());

            TriangleBuilder builder = new TriangleBuilder();
            Printer printer = new Printer();

            string triangle = builder.Build(size);
            printer.Print(triangle);
        }
    }
}
