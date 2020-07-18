using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04
{
    class Program
    {
        static void Main(string[] args)
        {
            LifeCycle.Customer ref_Customer = new LifeCycle.Customer(100, "Ali", "Kabiri");

            LifeCycle.Seller ref_Seller = new LifeCycle.Seller(500,"Mahsa","Ahmadi",2000000000);

            LifeCycle.Product[] ref_Products = new LifeCycle.Product[2] {
                  new LifeCycle.Product("Mobile",120000,10),
                new LifeCycle.Product("PC",800000,10),
            };

            LifeCycle.Invoice ref_Invoice = new LifeCycle.Invoice(12, 10, 9, ref_Products, ref_Customer, ref_Seller);

            Console.WriteLine(string.Format("Bill Code: {0} \n The Customer is : {1} \n The Seller is : {2} \n The TotalCost is {3} (Tax {4}% and Discount {5}% are included.)", ref_Invoice.Code, ref_Invoice.Customer.FullName, ref_Invoice.Seller.FullName, ref_Invoice.TotalCost, ref_Invoice.Tax, ref_Invoice.Discount));
            Console.ReadLine();
        }
    }
}
