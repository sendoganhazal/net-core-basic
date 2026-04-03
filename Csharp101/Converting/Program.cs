using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit Conversion *****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c; // eğer onlardan daha küçük kapasiteleri olsaydı buna izin vermezdi
            Console.WriteLine("d: " + d);
            long h = d;
            Console.WriteLine("h: " + h);
            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Hazal";
            char f = 'A';
            object g = e + f + d; //string ifadeler ve char ifadeler birleştirildiğinde sonuç string olur.
            Console.WriteLine("g: " + g);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***** Explicit Conversion *****");
            //Convert, Parse, toString metotları ile dönüşüm
            int x = 4;
            byte y = (byte)x; //int türündeki x değişkeni byte türüne dönüştürülür. Dönüşüm sırasında veri kaybı yaşanmaz çünkü byte, int türünden daha küçük bir kapasiteye sahiptir.
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z; //int türündeki z değişkeni byte türüne dönüştürülür. Dönüşüm sırasında veri kaybı yaşanır çünkü byte, int türünden daha küçük bir kapasiteye sahiptir. Bu nedenle t değişkeninin değeri 100 yerine 44 olur.
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w; //float türündeki w değişkeni byte türüne dönüştürülür. Dönüşüm sırasında veri kaybı yaşanır çünkü byte, float türünden daha küçük bir kapasiteye sahiptir. Bu nedenle v değişkeninin değeri 10 olur.
            Console.WriteLine("v: " + v);

            // *** ToString metodu ile dönüşüm ***
            Console.WriteLine("***** ToString Metodu ile Dönüşüm *****");
            int xx = 6;
            string yy = xx.ToString(); //int türündeki xx değişkeni string türüne dönüştürülür. 
                                       // Dönüşüm sırasında veri kaybı yaşanmaz çünkü string, int türünden daha büyük bir kapasiteye sahiptir.
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString(); //float türündeki 12.5 sayısı string türüne dönüştürülür. 
                                          // Dönüşüm sırasında veri kaybı yaşanmaz çünkü string, float türünden daha büyük bir kapasiteye sahiptir.
            Console.WriteLine("zz: " + zz);

            //*** System.Convert Sınıfı ile Dönüşüm ***
            Console.WriteLine("***** System.Convert Sınıfı ile Dönüşüm *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1); //string türündeki s1 değişkeni int türüne dönüştürülür. 
                                         // Dönüşüm sırasında veri kaybı yaşanmaz çünkü int, string türünden daha küçük bir kapasiteye sahiptir. 
            sayi2 = Convert.ToInt32(s2); //string türündeki s2 değişkeni int türüne dönüştürülür.
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);

            //*** Parse Metodu ile Dönüşüm ***
            Console.WriteLine("***** Parse Metodu ile Dönüşüm *****");
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1); //string türündeki metin1 değişkeni int türüne dönüştürülür. 
                                           // Dönüşüm sırasında veri kaybı yaşanmaz çünkü int, string türünden daha küçük bir kapasiteye sahiptir.  
            double1 = Double.Parse(metin2); //string türündeki metin2 değişkeni double türüne dönüştürülür. 
                                            // Dönüşüm sırasında veri kaybı yaşanmaz çünkü double, string türünden daha büyük bir kapasiteye sahiptir.
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);
        }
    }
}
