using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Entity'de diyoruz bunlara bunlar bir varlıktır.
    class Product
    {
        //Primary Key
        public int Id { get; set; }
        //Foreign Key
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //E-ticaret sistemin biz ürünü listeliyoruz arıyoruz ekliyoruz güncelliyoruz bunlara da biz en temelinde "CRUD" operasyonları diyoruz. 

    }
}
