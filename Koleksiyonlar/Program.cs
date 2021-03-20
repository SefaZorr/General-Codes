using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Arraylar onları oluşturdugumuz zaman o sınırlarda takılırlar sadece o sınırların dışına çıkamıyorlar.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////Böyle yapınca aslında biz new dedigimiz anda bellekte yeni bir adres oluşur 5 elemanlı bomboş bir array oluşturduk 0,1,2,3 bomboş yukarıdaki bambaşka adresti 
            ////biz gittik onun adresini degiştir new'leyerek.Yani dizilerdeki problem biz dizileri böyle sonradan genişletemiyoruz.Genişletirsek degeler gidiyor kayboluyor.
            ////Bu yuzden hayatımıza koleksiyonlar giriyor.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
