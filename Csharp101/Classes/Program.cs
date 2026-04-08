
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Class Syntax
            // class SinifAdi
            // {
            //     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
            //     {
            //         //Metot Gövdesi
            //     }
            // }
            // Erişim Belirleyiciler
            // Public, Private, Internal, Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "İlkkan";
            calisan1.Soyad = "Yedinci";
            calisan1.No = 12345678;
            calisan1.Departman = "IK";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Cagatay";
            calisan2.Soyad = "Yilmaz";
            calisan2.No = 87654321;
            calisan2.Departman = "Yonetim";

            calisan2.CalisanBilgileri();
        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
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


