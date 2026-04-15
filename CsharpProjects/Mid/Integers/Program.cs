namespace IntegerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayilari boslukla giriniz:");
            int[] sayilar = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            for (int i = 0; i < sayilar.Length - 1; i += 2)
            {
                int a = sayilar[i];
                int b = sayilar[i + 1];

                if (a == b)
                {
                    int sonuc = (int)Math.Pow(a + b, 2);
                    Console.Write(sonuc + " ");
                }
                else
                {
                    Console.Write((a + b) + " ");
                }
            }
        }
    }

}


