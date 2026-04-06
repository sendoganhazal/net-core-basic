namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //** Method Tanımlama
            Console.WriteLine("*****Method Tanımlama*****");
            //erisim_belirteci geri_donustipi method_adi(parametreListesi/arguman)
            // {
            //     //Komutlar
            // }
            int a = 2;
            int b =3;
            Console.WriteLine(a+b);

            int toplam = Topla(a,b);
            Console.WriteLine("Topla fonksiyonunun sonucu: " + toplam);

            Metodlar ornek = new Metodlar();
            ornek.EkranaYazdir(Convert.ToString(toplam));

            int sonuc = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir("Arttır ve Topla fonksiyonunun sonucu: " + sonuc);
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }
        public static int Topla(int deger1,int deger2)
        {
            return deger1 + deger2;
        }
    }
    class Metodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine("class metodu: {0}", veri);
        }
        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}





