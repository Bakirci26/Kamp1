using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gercek
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Bakırcı";
            musteri1.TcNo = "1234578656";


            //Tuzel
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "56865";
            musteri2.SirketAdi = "BAKIRCI İNSAAT";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
