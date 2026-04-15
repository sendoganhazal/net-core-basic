namespace ToDoApp
{
    public enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

    public class Kart
    {
        public string Baslik;
        public string Icerik;
        public int KisiId;
        public Buyukluk Boyut;
        public string Line;
    }
}