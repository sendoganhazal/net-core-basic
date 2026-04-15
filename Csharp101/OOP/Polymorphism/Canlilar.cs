namespace Polymorphism
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar Beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar Solunum Yaparlar");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlilar Bosaltim Yaparlar");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlilar Uyaranlara Tepki verir.");
        }
    }

}