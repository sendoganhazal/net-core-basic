namespace Inheritances
{
    public class Bitkiler : Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yaparlar");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu Bitkiler Tohumla Cogalirlar");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla Cogalirlar");
        }
    }

}