namespace MethodRecExt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            //Recursive - Öz Yinelemeli Metotlar
            Console.WriteLine("*****Recursive*****");
            // 3 ^ 4 = 3 * 3 * 3 * 3
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine("Sonuç: {0}", result);

            Islemler instance = new();
            // 3 ^ 4 = 3 * 3 * 3 * 3
            Console.WriteLine(instance.Expo(3, 4));
              
            //Extension Metotlar
            Console.WriteLine("*****Extension*****");
            string ifade = "Hazal Şendoğan";
            bool sonuc = ifade.CheckSpaces();
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeLowerCase());
            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi = {9, 3, 6, 2, 1, 5, 0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine($"{sayi} bir çift sayi mi? {sayi.IsEvenNumber()}");
            
            string metin = "Hazal";
            Console.WriteLine(metin.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {

            if (us < 2)
                return sayi;
            else if (us == 0)
                return 1;
            else
                return Expo(sayi, us - 1) * sayi;
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
          string[] dizi = param.Split(" ");
          return string.Join("_",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param %2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}

