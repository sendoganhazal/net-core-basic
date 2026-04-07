namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            //String Methods
            StringMethod();
        }
        public static void StringMethod()
        {
            string degisken = "Dersimiz Csharp , Hosgeldiniz!";
            string degisken2 = "dersimiz Csharp";

            Console.WriteLine("***** String Length*****");
            Console.WriteLine(degisken.Length);

            Console.WriteLine("***** String ToUpper*****");
            Console.WriteLine(degisken.ToUpper());

            Console.WriteLine("***** String ToLower*****");
            Console.WriteLine(degisken.ToLower());

            Console.WriteLine("***** String Concat*****");
            Console.WriteLine(String.Concat(degisken, ", Merhaba!"));

            Console.WriteLine("***** Compare to *****"); // Birinci degisken ikinci degiskene eşitse 0, birinci degisken ikinci degiskenden alfabetik olarak önceyse -1, sonra ise 1 döner.
            Console.WriteLine(degisken.CompareTo(degisken2));


            Console.WriteLine("*****Compare*****");
            Console.WriteLine(String.Compare(degisken, degisken2, true)); // Büyük küçük harf duyarlılığını kaldırmak için true yazılır.
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            Console.WriteLine("*****Contains*****");
            Console.WriteLine(degisken.Contains(degisken2)); // bulursa true, bulamazsa false.

            Console.WriteLine("*****EndsWith*****");
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); // Sonunuzun ne ile bittiğini kontrol eder.

            Console.WriteLine("*****StartsWith*****");
            Console.WriteLine(degisken.StartsWith("Merhaba")); // Başlangıcını kontrol eder.

            Console.WriteLine("*****IndexOf*****");
            Console.WriteLine(degisken.IndexOf("Csharp")); // Verilen string'in index numarasını döner.
            Console.WriteLine(degisken.IndexOf("Hazal")); // - 1

            Console.WriteLine("*****LastIndexOf*****");
            Console.WriteLine(degisken.LastIndexOf("i")); // Verilen string'in index numarasını döner.
            Console.WriteLine(degisken.LastIndexOf("Hazal")); // - 1

            Console.WriteLine("*****Insert*****");
            Console.WriteLine(degisken.Insert(0, "Hazal, "));

            Console.WriteLine("*****PadLeft*****");
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine("*****PadRight*****");
            Console.WriteLine(degisken.PadRight(50, '*') + degisken2);

            Console.WriteLine("*****Remove*****");
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            Console.WriteLine("*****Replace*****");
            Console.WriteLine(degisken.Replace("Csharp", "C#"));

            Console.WriteLine("*****Split*****");
            Console.WriteLine(degisken.Split(' ')[1]);

            Console.WriteLine("*****Substring*****");
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
            Console.WriteLine(degisken.Substring(0, 2));
        }
    }
}


