using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir ifade giriniz:");
        string input = Console.ReadLine();

        string[] kelimeler = input.Split(' ');

        for (int i = 0; i < kelimeler.Length; i++)
        {
            string kelime = kelimeler[i];

            if (kelime.Length > 1)
            {
                char ilk = kelime[0];
                char son = kelime[kelime.Length - 1];
                string orta = kelime.Substring(1, kelime.Length - 2);

                kelimeler[i] = son + orta + ilk;
            }
        }

        Console.WriteLine(string.Join(" ", kelimeler));
    }
}
