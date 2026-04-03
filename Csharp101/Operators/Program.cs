using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //Atama ve İşlemli Atama
            Console.WriteLine("***** Atama ve İşlemli Atama *****");
            int x = 3;
            int y = 3;
            y += 2; //y'nin değeri 2 olur.
            Console.WriteLine(y); //y'nin değeri ekrana yazdırılır. Ekranda 2 yazısı görünür.
            y += 2; //y'nin değeri 2 olur.
            Console.WriteLine(y); //y'nin değeri ekrana yazdırılır. Ekranda 2 yazısı görünür.

            y /= 3;
            Console.WriteLine(y); 

            x *= 2; //x'in değeri 6 olur.
            Console.WriteLine(x); //x'in değeri ekrana yazdırılır. Ekranda 6 yazısı görünür.

            //Mantıksal Operatörler
            Console.WriteLine("***** Mantıksal Operatörler *****");
            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted) //isSuccess ve isCompleted değişkenlerinin her ikisi de true ise if bloğu çalışır.
                Console.WriteLine("Perfect!");
            if (isSuccess || isCompleted) //isSuccess veya isCompleted değişkenlerinin herhangi biri true ise if bloğu çalışır.
                Console.WriteLine("Great!"); 
            if (isSuccess && !isCompleted) 
                Console.WriteLine("Fine!"); 

            //İlişkisel Operatörler
            Console.WriteLine("***** İlişkisel Operatörler *****");
            int a = 3;
            int b = 5;
            bool sonuc = a < b; //a'nın b'den küçük olup olmadığını kontrol eder ve sonuc değişkenine true veya false değerini atar.
            Console.WriteLine(sonuc); //sonuc değişkeninin değeri ekrana yazdırılır. Ekranda true yazısı görünür.
            sonuc = a > b; //a'nın b'den büyük olup olmadığını kontrol eder ve sonuc değişkenine true veya false değerini atar.
            Console.WriteLine(sonuc); //sonuc değişkeninin değeri ekrana yazdırılır. Ekranda false yazısı görünür.
            sonuc = a >= b; //a'nın b'den büyük veya eşit olup olmadığını kontrol eder ve sonuc değişkenine true veya false değerini atar.
            Console.WriteLine(sonuc); //sonuc değişkeninin değeri ekrana yazdırılır. Ekranda false yazısı görünür.
            sonuc = a <= b; //a'nın b'den küçük veya eşit olup olmadığını kontrol eder ve sonuc değişkenine true veya false değerini atar.
            Console.WriteLine(sonuc); //sonuc değişkeninin değeri ekrana yazdırılır. Ekranda true yazısı görünür.
            sonuc = a == b; //a'nın b'ye eşit olup olmadığını kontrol eder ve sonuc değişkenine true veya false değerini atar.
            Console.WriteLine(sonuc); //sonuc değişkeninin değeri ekrana yazdırılır. Ekranda false yazısı görünür.
            sonuc = a != b; //a'nın b'ye eşit olmadığını kontrol eder ve sonuc değişkenine true veya false değerini atar.
            Console.WriteLine(sonuc); //sonuc değişkeninin değeri ekrana yazdırılır. Ekranda true yazısı görünür.

            //Aritmetik Operatörler
            Console.WriteLine("***** Aritmetik Operatörler *****");
            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi + sayi2;
            Console.WriteLine(sonuc1); 
            int sonuc2 = sayi - sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3 = sayi * sayi2;
            Console.WriteLine(sonuc3);
            int sonuc4 = ++sayi;
            Console.WriteLine(sonuc4); 
            int sonuc5 = --sayi;
            Console.WriteLine(sonuc5);  
            int sonuc6 = 20%3; //20 sayısının 3'e bölümünden kalanı verir. Sonuç 2 olur.
            Console.WriteLine(sonuc6);

        }
    }
}
