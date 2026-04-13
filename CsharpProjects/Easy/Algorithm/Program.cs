using System;

namespace StringCharRemoveApp
{
    // String işleme sorumluluğu
    class StringProcessor
    {
        public string RemoveCharAt(string text, int index)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            if (index < 0 || index >= text.Length)
                return text;

            return text.Remove(index, 1);
        }
    }

    // Input ayrıştırma sorumluluğu (GÜNCELLENDİ)
    class InputParser
    {
        public (string text, int index) Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Boş input girilemez!");

            string[] parts = input.Split(',');

            if (parts.Length != 2)
                throw new Exception("Hatalı format! Örnek: Algoritma,3");

            string text = parts[0].Trim();

            if (!int.TryParse(parts[1].Trim(), out int index))
                throw new Exception("Index sayı olmalıdır!");

            return (text, index);
        }
    }

    class Printer
    {
        public void Print(string result)
        {
            Console.Write(result + " ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InputParser parser = new InputParser();
            StringProcessor processor = new StringProcessor();
            Printer printer = new Printer();

            Console.WriteLine("Girişleri virgülle yazınız (örn: Algoritma,3):");
            Console.WriteLine("Çıkmak için boş satır giriniz.\n");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                try
                {
                    var (text, index) = parser.Parse(input);

                    string result = processor.RemoveCharAt(text, index);

                    printer.Print(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }
    }
}