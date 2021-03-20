using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Alternatif yani imzanın fonksiyonun aynı oldugu ama içerisinin farklı oldugu durumlarda biz class yerine interface  kullanırız.Bir interface sunu anlatır eger ki
    //birisi bu interfaci kullanırsa o arkadaşımız bu metodu yada metotları içermek zorundadır.Genellikle operasyonel metotlarda kullanıyoruz interfaceleri.
    //İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
