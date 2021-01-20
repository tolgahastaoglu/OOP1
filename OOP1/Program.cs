using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice =500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=3,ProductName="Ayakkabı",UnitPrice=250,UnitsInStock=25 };
            // Bu iki yazım arasında hiç bir fark yoktur..

            // case sensitive Büyük küçük harf duyarlı
            //pascal case  // camel case
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
            
    }
}
