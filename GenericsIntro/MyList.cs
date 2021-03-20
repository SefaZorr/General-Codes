using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generic class.
    class MyList<T>
    {
        T[] items;
        //Constructor
        //MyList'i oluşturdugumuz gibi items diye 0 elamanlı bir array'miz oluşuyor. 
        public MyList()
        {
            items = new T[0]; 
        }
        public void Add(T item)
        {
            T[] tempArray = items;//New ledikten sonra elemanlarımız kaybolmasın diye referansımızı geçici bir diziye verdik.
            items = new T[items.Length + 1];//Eleman sayısını 1 arttırdık eleman ekleyince eleman sayısını arttırıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//Geçici array'e verdigimiz elemanları sırasıyla yeni diziye geri alıyoruz.
            }
            items[items.Length - 1] = item;//Son olarak aslında eklemek istedigimiz elemanı ekledik mesela items 6 elamanlı 1 eksigi oluyor  en son eleman olarak.
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
