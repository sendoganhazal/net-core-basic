namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            //out parametreler
            Console.WriteLine("*****out parametreler*****");
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarili!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarisiz!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine("Toplam: {0}", toplamSonucu);

            //Metod Overloading
            Console.WriteLine("*****Metod Overloading*****");
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Hazal", "Şendoğan");
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine("String veri: {0}", veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine("Int veri: {0}", veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + " " + veri2);
        }
    }
}
