namespace DateTimeMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derste Öğrenilenler");

            //DateTime Methods
            Console.WriteLine("***** DateTime Methods *****");
            DateTimeMethods();

            //Math Methods
            Console.WriteLine("***** Math Methods *****");
            MathMethods();
        }
        public static void DateTimeMethods()
        {
            Console.WriteLine("*** Now ***");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("*** Date ***");
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine("*** Day ***");
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine("*** Month ***");
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine("*** Year ***");
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine("*** Hour ***");
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine("*** Minute ***");
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine("*** Second ***");
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine("*** Day Of Week ***");
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine("*** Day Of Year ***");
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine("*** LongDateString ***");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine("*** ShortDateString ***");
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine("*** LongTimeString ***");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("*** ShortTimeString ***");
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine("*** Add Day ***");
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine("*** Add Hour ***");
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine("*** Add Second ***");
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine("***Add  Month ***");
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine("***Add Year ***");
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine("*** Milisecond ***");
            Console.WriteLine(DateTime.Now.AddMilliseconds(100));

            Console.WriteLine("*** Datetime Format ***");
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd"));
        }
        public static void MathMethods()
        {
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            Console.WriteLine(Math.Ceiling(22.3)); //yukarı 22
            Console.WriteLine(Math.Round(22.3));//.5'ten büyükse üste, küçükse aşağı. 22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));// aşağı 22

            Console.WriteLine(Math.Min(2,6)); //en küçüğünü verir
            Console.WriteLine(Math.Max(2,6)); //en büyüğünü verir

            Console.WriteLine(Math.Pow(3,4)); //üs alma
            Console.WriteLine(Math.Sqrt(49)); //karekök
            Console.WriteLine(Math.Log(56)); // logaritma
            Console.WriteLine(Math.Exp(3));// e üzeri 3
        }
    }
}


