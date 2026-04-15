namespace InterfaceExample
{
    public class Golf : IOtomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public Marka AracinMarkasi()
        {
            return Marka.Volkswagen;
        }
        public Renk StandartRenk()
        {
            return Renk.Kirmizi;
        }
    }

}