namespace InterfaceExample
{
    public class Focus : IOtomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public Marka AracinMarkasi()
        {
            return Marka.Ford;
        }
        public Renk StandartRenk()
        {
            return Renk.Beyaz;
        }
    }

}