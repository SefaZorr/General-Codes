using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Böyle olunca kredi bagımsız oldu başvurumuz.
        //Burada dependency injectionun method injection modelini yapıyoruz parametre olarak hangi kredi olacagını ve hangi loglayıcı olacagını enjekte 
        //Aynı anda hem sms hemde database log yapıcaksak list<ILoggerService> yaparız.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme.

            //Bu dogru bir şey degil çünkü bütün başvurları konut kredisi üzerinden almış olduk.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            krediManager.Hesapla();
            loggerService.Log();
        }

        //Burada birden fazla kredi için bi hesaplama yapıyor yukarıda ise direk basvuru yapıyor.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
