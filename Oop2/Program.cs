using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



            //musteri3 ve musteri4 ikisinide tutabiliyor (gercek ve tüzel'i) yani ikisininde referansını tutabiliyor.O yüzden musterimanager add metoduna musteri diye
            //parametre gönderdik ikisinide ekleyebilelim diye.Olay tamamen base sınıfın onu inherit eden tuzel ve gercek musterının referansını tutabilmesi.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            //Gercek Müşteri - Tüzel Müşteri nesnelerimiz var bunlar aslında ikiside musteri bunlar sırf birbirine benziyor diye birbiri yerine kullanılamazlar.
        }
    }
}
