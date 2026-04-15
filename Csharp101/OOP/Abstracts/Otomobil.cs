namespace Abstracts
{
    public abstract class Otomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public virtual Renk StandartRenk()
        {
            return Renk.Beyaz;
        }

        public abstract Marka AracinMarkasi();
    }
}