namespace InterfaceExample
{
    public class Civic : IOtomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public Marka AracinMarkasi()
        {
            return Marka.Honda;
        }
        public Renk StandartRenk()
        {
            return Renk.Mavi;
        }
    }

}