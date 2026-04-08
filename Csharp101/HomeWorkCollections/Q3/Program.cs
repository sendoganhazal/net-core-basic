
using System.Collections;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
                Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
                ve dizinin elemanlarını sıralayan programı yazınız.
            **/
            Console.Write("Lütfen Bir Cümle Giriniz:");
            string sentences = Console.ReadLine();
            sentences.ToLower();

            ArrayList vowels = new ArrayList();
            foreach (var letter in sentences)
            {
                if (letter == 'a' || letter == 'e' || letter == 'ı' || letter == 'i' || letter == 'o' || letter == 'ö' || letter == 'u' || letter == 'ü')
                {
                    if (!vowels.Contains(letter))
                        vowels.Add(letter);
                }
            }

            Console.WriteLine("\n*** Cümledeki Sesli Harfler ***");
            foreach (var character in vowels)
            {
                Console.WriteLine(character);
            }

        }
    }
}

