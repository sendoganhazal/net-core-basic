namespace Abstracts
{
    public class Golf : Otomobil
    {
        public override Marka AracinMarkasi()
        {
            return Marka.Volkswagen;
        }
        public override Renk StandartRenk()
        {
            return Renk.Kirmizi;
        }
    }

}