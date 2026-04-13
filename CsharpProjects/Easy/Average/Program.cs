using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciAverageApp
{
    // Fibonacci üretiminden sorumlu sınıf
    class FibonacciService
    {
        public List<int> Generate(int depth)
        {
            List<int> fib = new List<int>();

            if (depth <= 0)
                return fib;

            fib.Add(0);
            if (depth == 1)
                return fib;

            fib.Add(1);

            for (int i = 2; i < depth; i++)
            {
                int next = fib[i - 1] + fib[i - 2];
                fib.Add(next);
            }

            return fib;
        }
    }

    // Ortalama hesaplamadan sorumlu sınıf
    class AverageService
    {
        public double Calculate(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return 0;

            return numbers.Average();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci derinliğini giriniz: ");
            int depth = int.Parse(Console.ReadLine());

            FibonacciService fibService = new FibonacciService();
            AverageService avgService = new AverageService();

            var fibonacciNumbers = fibService.Generate(depth);
            double average = avgService.Calculate(fibonacciNumbers);

            Console.WriteLine("\nFibonacci Serisi:");
            foreach (var num in fibonacciNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine($"\n\nOrtalama: {average}");
        }
    }
}

