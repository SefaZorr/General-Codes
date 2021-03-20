using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Bu olaya miras (inheritance) diyoruz tüzel müşteri bir müşteridir demek.
    //Müşteriden olan özellikler artık ondan kalıtım alanlarda da vardır.
    //Inheritance yapma sebimiz 
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
