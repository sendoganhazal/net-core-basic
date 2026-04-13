namespace TryCatches
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayi Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi = {0}", sayi);
            }
            catch (System.Exception ex)
            {
                // TODO
                Console.WriteLine("Hata: {0}", ex.Message); // hatalı data girilince hata verir 
            }
            finally
            {
                Console.WriteLine("İslem Tamamlandi"); //ne olursa olsun bu kod bloğu çalışacak.
            }

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
                // Bos deger girdiniz
                // System.ArgumentNullException: Value cannot be null. (Parameter 's')
                //    at System.Int32.Parse(String s)
                //    at TryCatches.Program.Main(String[] args) in C:\Users\Maarifa 1\Desktop\net-core-basic\Csharp101\TryCatches\Program.cs:line 26
            }

            try
            {
                int a = int.Parse("test");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
                // Veri tipi uygun degil
                // System.FormatException: The input string 'test' was not in a correct format.
                //     at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
                //     at System.Int32.Parse(String s)
                //     at TryCatches.Program.Main(String[] args) in C:\Users\Maarifa 1\Desktop\net-core-basic\Csharp101\TryCatches\Program.cs:line 40
            }

            try
            {
                int a = int.Parse("-200000000000");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cok kucuk veya cok buyuk bir deger girdiniz");
                Console.WriteLine(ex);
                // Cok kucuk veya cok buyuk bir deger girdiniz
                // System.OverflowException: Value was either too large or too small for an Int32.
                //     at System.Number.ThrowOverflowException[TInteger]()
                //     at System.Int32.Parse(String s)
                //     at TryCatches.Program.Main(String[] args) in C:\Users\Maarifa 1\Desktop\net-core-basic\Csharp101\TryCatches\Program.cs:line 55
            }
        }
    }
}


