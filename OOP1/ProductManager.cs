using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Burada ise product sınıf ile ilgili operasyonlarımızı yazıyoruz "ProductServide" de yazabilirdik isim olarak.Ekleme silme arama güncelleme operasyonları olur burada.
    class ProductManager
    {
        //Void diye belirttigimiz metotlar git sil git güncelle diyoruz tamamen emir kipiyle çagırıyoruz ve o işlemi yapıp bitiriyor bu işlem sonucunun ne olduguyla ilgili
        //ekstra bilgiye gerek yoksa bunu kullanıyoruz.

        //Mesela bir toplama metodunu biz 2 şekilde yazabiliriz 1.void ile console.writeline ile cevabı yazarız 2. ise int ile yazıp return edebiliriz direk sonucu.Return'e
        //niye ihtiyacımız var  ortaya çıkan sonucu başka bir yerde kullanmak istiyorsak return ile kullanmamız lazım.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
