using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir ifade giriniz:");
        string input = Console.ReadLine().ToLower();

        string[] kelimeler = input.Split(' ');

        foreach (string kelime in kelimeler)
        {
            Console.Write(CheckConsonants(kelime) + " ");
        }
    }

    static bool CheckConsonants(string kelime)
    {
        string sessizler = "bcçdfgğhjklmnprsştvyz";

        for (int i = 0; i < kelime.Length - 1; i++)
        {
            if (sessizler.Contains(kelime[i]) && sessizler.Contains(kelime[i + 1]))
            {
                return true;
            }
        }

        return false;
    }
}