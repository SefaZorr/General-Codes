using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 numara mobilyaya karşılık gelsin arka planda mesela.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Bu şekildede yazılabilir product.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase
            //Case sensitive => büyük küçük harf duyarlıdır.
            //Stack                  //Heap    
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);//Atamalar bellekteki adres ile yapılır referans tipte.
            Console.WriteLine(product1.ProductName);//Kamera.



            //int,double,bool... değer tip.
            //diziler,class,abstract class,interface... referans tip.
        }
    }
}
