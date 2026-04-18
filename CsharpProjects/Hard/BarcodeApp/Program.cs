using System;
using System.Drawing;
using System.IO;
using ZXing;

namespace SimpleBarcodeApp
{
    class Program
    {
        static string filePath = @"C:\Barcodes\barcode.png";

        static void Main(string[] args)
        {
            Console.WriteLine("1 - Barcode Oluştur");
            Console.WriteLine("2 - Barcode Oku");
            Console.Write("Seçim: ");

            string secim = Console.ReadLine();

            if (secim == "1")
                BarcodeOlustur();
            else if (secim == "2")
                BarcodeOku();
        }

        static void BarcodeOlustur()
        {
            Console.Write("Metin gir: ");
            string text = Console.ReadLine();

            var writer = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.CODE_128
            };

            Bitmap image = writer.Write(text);

            Directory.CreateDirectory(@"C:\Barcodes");
            image.Save(filePath);

            Console.WriteLine("Barcode oluşturuldu: " + filePath);
        }

        static void BarcodeOku()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Dosya yok!");
                return;
            }

            Bitmap image = (Bitmap)Image.FromFile(filePath);

            var reader = new ZXing.BarcodeReader();

            var result = reader.Decode(image);

            if (result != null)
                Console.WriteLine("Okunan değer: " + result.Text);
            else
                Console.WriteLine("Barcode okunamadı.");
        }
    }
}