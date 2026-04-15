namespace Abstracts
{
    public class Civic : Otomobil
    {
        public override Marka AracinMarkasi()
        {
            return Marka.Honda;
        }

        public override Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }

}