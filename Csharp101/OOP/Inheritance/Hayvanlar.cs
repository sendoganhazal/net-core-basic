namespace Inheritances
{
    public class Hayvanlar : Canlilar
    {
       protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasayon Yapabilir");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void Hareket()
        {
            Console.WriteLine("Surungenler surunerek hareket ederler");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void Hareket()
        {
            Console.WriteLine("Kuslar ucarak hareket ederler");
        }
    }

}