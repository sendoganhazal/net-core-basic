
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calisan 1 ***");
            Calisan calisan1 = new Calisan("İlkkan", "Yedinci", 12345678, "IK");
            calisan1.CalisanBilgileri();
            Console.WriteLine("*** Calisan 2 ***");
            Calisan calisan2 = new Calisan("Cagatay", "Yilmaz", 87654321, "Yonetim");
            calisan2.CalisanBilgileri();
            Console.WriteLine("*** Calisan 3 ***");
            Calisan calisan3 = new Calisan("Hazal", "Sendogan");
            calisan3.CalisanBilgileri();
        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman) //Constructor
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }

            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }
            public Calisan() { }
            public void CalisanBilgileri()
            {
                Console.WriteLine("Calisan Adi: {0}", Ad);
                Console.WriteLine("Calisan Soyad: {0}", Soyad);
                Console.WriteLine("Calisan Sicil No: {0}", No);
                Console.WriteLine("Calisan Departmani: {0}", Departman);
            }
        }
    }
}



