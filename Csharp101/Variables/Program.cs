using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");
            int deger = 2;
            // string degisken = null;// aynı değişken birden fazla tanımlanamaz. Bu yüzden deger ve Degisken farklı değişkenlerdir.
            // string Degisken = null;//degisken ve Degisken birbirinden farklı değişkenlerdir. C# büyük küçük harf duyarlıdır.
            // string class =""; Bu hata verir çünkü class bir keyword'tür.
            // string degisken_veri = null; //alt çizgi kullanarak değişken tanımlayabiliriz.
            
            // veri türleri
            string metin = " "; //Boşluk da bir karakterdir. Burada boşluk karakteri tanımlanmıştır.
            char karakter = '2'; //1 byte yer kaplar. Tek tırnak içinde tanımlanır. Tek bir karakter tutar. 

            byte b = 5; //1 byte yer kaplar. 0 ile 255 arasında değer alabilir.
            sbyte c = 5; //1 byte yer kaplar. -128 ile 127 arasında değer alabilir.

            short s = 5; //2 byte yer kaplar. -32.768 ile 32.767 arasında değer alabilir.
            ushort u = 5; //2 byte yer kaplar. 0 ile 65.535 arasında değer alabilir.

            Int16 i16 = 2; //2 byte yer kaplar. -32.768 ile 32.767 arasında değer alabilir.
            int i = 2; //4 byte yer kaplar. -2.147.483.648 ile 2.147.483.647 arasında değer alabilir.
            Int32 i32 = 2; //4 byte yer kaplar. -2. 147.483.648 ile 2.147.483.647 arasında değer alabilir.
            Int64 i64 = 2; //8 byte yer kaplar. -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 arasında değer alabilir.
            uint u32 = 2; //4 byte yer kaplar. 0 ile 4.294.967.295 arasında değer alabilir.

            long l = 2; //8 byte yer kaplar. -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 arasında değer alabilir.
            ulong ul = 2; //8 byte yer kaplar. 0 ile 18.446.744.073.709.551.615 arasında değer alabilir.

            // Reel sayılar için kullanılan veri türleri:
            float f = 2; //4 byte yer kaplar. 1.5 x 10^-45 ile 3.4 x 10^38 arasında değer alabilir.  
            double d = 2; //8 byte yer kaplar. 5.0 x 10^-324 ile 1.7 x 10^308 arasında değer alabilir.Genellikle bilimsel hesaplamalar için tercih edilir.
            decimal de = 2; //16 byte yer kaplar. 1.0 x 10^-28 ile 7.9 x 10^28 arasında değer alabilir. Genellikle finansal işlemler için tercih edilir.

            bool b1 = true; //1 byte yer kaplar. true veya false değerlerini alabilir. Mantıksal veri türüdür.
            bool b2 = false; //1 byte yer kaplar. true veya false değerlerini alabilir. Mantıksal veri türüdür.

            DateTime dt = DateTime.Now; //8 byte yer kaplar. Tarih ve saat bilgilerini tutar.

            object o1 = "x"; //object türü tüm veri tiplerinin atasıdır. Herhangi bir veri tipini tutabilir.
            object o2 = 'y';   

            // string ifadeler
            string str1 = string.Empty; //string.Empty ifadesi, boş bir string'i temsil eder. Yani, str1 değişkeni boş bir string olarak tanımlanır.
            str1 = "Ali Veli"; //str1 değişkenine "Ali Veli" string değeri atanır.  
            Console.WriteLine(str1); //str1 değişkeninin değeri ekrana yazdırılır. Ekranda "Ali Veli" yazısı görünür.
            
            string ad = "Hazal";
            string soyad = "Şendoğan";
            string tamIsim = ad + " " + soyad; //string ifadeler birbirine + operatörü ile eklenebilir. 
            // Burada ad ve soyad değişkenleri birleştirilerek tamIsim değişkenine atanır.
            Console.WriteLine(tamIsim);

            // integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2; //integer1 ve integer2 değişkenleri çarpılarak integer3 değişkenine atanır.
            Console.WriteLine(integer3); //integer3 değişkeninin değeri ekrana yazdırılır. Ekranda 15 yazısı görünür.

            // boolean ifadeler
            bool bool1 = 10 > 2; //10 sayısı 2 sayısından büyük olduğu için bool1 değişkenine true değeri atanır.
            bool bool2 = 10 < 2; //10 sayısı 2 sayısından küçük olmadığı için bool2 değişkenine false değeri atanır.
            Console.WriteLine(bool1); //bool1 değişkeninin değeri ekrana yazdırılır. Ekranda true yazısı görünür.
            Console.WriteLine(bool2); //bool2 değişkeninin değeri ekrana yazdırılır. Ekranda false yazısı görünür.

            // Değişken dönüşümleri
            string str20 = "20"; ;
            int int20 = int.Parse(str20);
            string yeniDeger = str20 + int20.ToString(); 
            Console.WriteLine(yeniDeger); //yeniDeger değişkeninin değeri ekrana yazdırılır. Ekranda 2020 yazısı görünür.
            
            int int21 = int20 + Convert.ToInt32(str20); //int20 değişkeni ile str20 değişkeni toplanarak int21 değişkenine atanır. 
            // Convert.ToInt32() metodu, str20 değişkenini int türüne dönüştürür.
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20); //int20 değişkeni ile str20 değişkeni toplanarak int22 değişkenine atanır.
            // int.Parse() metodu, str20 değişkenini int türüne dönüştürür.
            Console.WriteLine(int22);

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); //DateTime.Now ifadesi, o anki tarih ve saat bilgisini verir. 
            // ToString("dd.MM.yyyy") ifadesi ise bu bilgiyi "gün.ay.yıl" formatında string'e dönüştürür.
            Console.WriteLine(datetime); //datetime değişkeninin değeri ekrana yazdırılır.

            string datetime2= DateTime.Now.ToString("dd.MM.yyyy"); //DateTime.Now ifadesi, o anki tarih ve saat bilgisini verir. 
            // ToString("dd.MM.yyyy") ifadesi ise bu bilgiyi "gün.ay.yıl" formatında string'e dönüştürür.
            Console.WriteLine(datetime2); //datetime değişkeninin değeri ekrana yazdırılır.
            string  hour = DateTime.Now.ToString("HH:mm"); //DateTime.Now ifadesi, o anki tarih ve saat bilgisini verir. 
            Console.WriteLine(hour); //hour değişkeninin değeri ekrana yazdırılır. Ekranda o anki saat ve dakika bilgisi görünür.

            Console.WriteLine(deger);
            Console.WriteLine("string: " + metin);
            Console.WriteLine("char: " + karakter);
            Console.WriteLine("byte: " + b);
            Console.WriteLine("sbyte: " + c);
            Console.WriteLine("short: " + s);
            Console.WriteLine("ushort: " + u);
            Console.WriteLine("Int16: " + i16);
            Console.WriteLine("int: " + i);
            Console.WriteLine("Int32: " + i32);
            Console.WriteLine("Int64: " + i64);
            Console.WriteLine("uint: " + u32);
            Console.WriteLine("long: " + l);
            Console.WriteLine("ulong: " + ul);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + de);
            Console.WriteLine("bool: " + b1);
            Console.WriteLine("bool: " + b2);
            Console.WriteLine("DateTime: " + dt);
            Console.WriteLine("object: " + o1);
            Console.WriteLine("object: " + o2);
        }
    }
}