using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[] { new Product{ProductId=1,ProductName="kalem",UnitsInStock=144,UnitPrice=17 },
                                                 new Product{ProductId=1,ProductName="defter",UnitsInStock=78,UnitPrice=32 },
                                                 new Product{ProductId=1,ProductName="hesap makinesi",UnitsInStock=21,UnitPrice=140 },
                                                 new Product{ProductId=1,ProductName="silgi",UnitsInStock=141,UnitPrice=9 }
                                                };
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "teleskop";
            product1.UnitsInStock = 2;
            product1.UnitPrice = 2230;
           
            Product product2 = new Product();
            product2.ProductId = 1;
            product2.ProductName = "ayna";
            product2.UnitsInStock = 2;
            product2.UnitPrice = 2230;
            
            Product product3 = new Product();
            product3.ProductId = 1;
            product3.ProductName = "mercek";
            product3.UnitsInStock = 2;
            product3.UnitPrice = 2230;

            Product[] products2 = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
            foreach (Product product in products2)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
