using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int,decimal,float,enum,boolean bunlar deger tiptir.(Value type).Deger tipler bellekte stack'te tanımlanır.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? => 30.

             
            //Array,class,interface... reference tiptir.Referans tipler bellekte hem stackte hem heap te tutulur new dedigimiz anda bellekte heapte bir adres oluşuyor.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] => 999.



        }
    }
}
