using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mehmet Beken
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Beken";
            musteri1.TcNo = "123456";

            //Kodlama.IO

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5645646";
            musteri2.SirketAdi = "KodlamaIO";
            musteri2.VergiNo = "123665";


            //Gerçek Müşteri/Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new GercekMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
