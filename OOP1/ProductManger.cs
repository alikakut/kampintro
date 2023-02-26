using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManger
    {
        public void Add(product product)
        {
            Console.WriteLine(product+  "eklendi.");
        }


        public void update(product product)
        {
            Console.WriteLine(product.Productname+  "güncellendi");
        }
         
    }

}// void=git yap bitir  yapıp bitirir.
