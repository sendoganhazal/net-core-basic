
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
                Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
                her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
                ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            **/
            int x = 20;
            int quantity = 3;
            int number;
            int totalOfMinimums = 0;
            int totalOfMaximums = 0;
            float averageOfMinimums = 0;
            float averageOfMaximums = 0;

            int[] numbers = new int[x];
            int[] minimums = new int[quantity];
            int[] maximums = new int[quantity];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Lütfen değer giriniz: ");
                number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Array.Sort(numbers);
            

            minimums[0] = numbers[0];
            minimums[1] = numbers[1];
            minimums[2] = numbers[2];

            totalOfMinimums = minimums[0] + minimums[1] + minimums[2];
            averageOfMinimums = totalOfMinimums / quantity;

            Array.Reverse(numbers);

            maximums[0] = numbers[0];
            maximums[1] = numbers[1];
            maximums[2] = numbers[2];

            totalOfMaximums = maximums[0] + maximums[1] + maximums[2];
            averageOfMaximums = totalOfMaximums / quantity;

            Console.WriteLine($"Minimumlar Toplami \t {totalOfMinimums}");
            Console.WriteLine($"Minimumlar Ortalamasi \t {averageOfMinimums}");
            Console.WriteLine($"Maximumlar Toplami \t {totalOfMaximums}");
            Console.WriteLine($"Maximumlar Ortalamasi \t {averageOfMaximums}");
        }
    }
}
