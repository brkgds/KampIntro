using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. ");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");

        }
    }
    // ürünlerle ilgili operasyonlar var burada..
}
