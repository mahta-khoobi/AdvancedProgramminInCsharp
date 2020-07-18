using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03
{
    public class Program
    {
        static void Main(string[] args)
        {
            LifeCycle.Order ref_Order = new LifeCycle.Order(new LifeCycle.Person("B","A",101),new LifeCycle.Person("D","C",122),10211);
            ref_Order.ProductsInitializer();
            ref_Order.Products.Add(new LifeCycle.Product(10, 120000, "Mobile", 1021));
            ref_Order.Buyer.SetAddress(new LifeCycle.Address(new LifeCycle.City(98, "Tehran"), new LifeCycle.Country(100, "Iran"), "Vanak st", 21));
            //ref_Order.Seller.GetPosition("Manager", 2);
            Console.WriteLine(string.Format("Seller : {0} Job Title : {4} Buyer :{1} Buyer's Country : {2} Product Name:{3}",ref_Order.Seller.Name,ref_Order.Buyer.Name,ref_Order.Buyer.Address.Country.Name,ref_Order.Products[0].Name,ref_Order.Seller.GetPosition("Manager",2).Title));
            Console.ReadKey();
        }
    }
}
