using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Productname = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            product product2=new product { Id=2,CategoryId=5,Productname="kalem",UnitsInStock=30,UnitPrice=5};
            //yukurıdaki kulanımlar aynı ama yazımları farklı.


            ProductManger productManger = new ProductManger();
            productManger.Add(product1);

        
        }
    }
}
