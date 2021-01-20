using System;
using System.Collections.Generic;
using System.Text;

namespace OPP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " Silindi.");
        }





    }
}
