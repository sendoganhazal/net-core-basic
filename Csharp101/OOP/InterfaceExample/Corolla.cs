namespace InterfaceExample
{
    public class Corolla : IOtomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public Marka AracinMarkasi()
        {
            return Marka.Toyota;
        }
        public Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }

}