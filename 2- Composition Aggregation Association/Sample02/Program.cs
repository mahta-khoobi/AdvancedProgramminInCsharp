using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Order ref_Order = new Order(new Person(201, "Maryam", "Ahmadi"), 555,100,"Amir","Kabiri");
            ref_Order.ProductsInitializer();
            ref_Order.Ref_Product.Add(new Product(1, "Mobile", 2, 1200000));
            ref_Order.Ref_Product.Add(new Product(2, "PC", 1, 8000000));
            Console.WriteLine(string.Format(" Bill Code:{0}\n Seller: {1} Position:{2}\n Buyer: {3}\n TotalPrice:{4}",ref_Order.Code,ref_Order.Seller.FullInfo,ref_Order.Seller.GetPosition("Manager",2).Title,ref_Order.Buyer.FullInfo,ref_Order.TotalPrice));

            
        }
    }
}
