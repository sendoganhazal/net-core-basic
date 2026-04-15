namespace TelefonRehberi
{
    public class Kisi
    {
        private string ad;
        private string soyad;
        private string telNo;
        public Kisi(string ad, string soyad, string numara)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.telNo = numara;
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
    }
}