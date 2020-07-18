using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Order
    {
        #region [- ctor -]
        public Order(Person buyer ,int code ,int sellerCode ,string sellerName, string sellerSurname)
        {
            Seller = new Person(sellerCode,sellerName,sellerSurname);
            Buyer = buyer;
            Code = code;
        }
        #endregion

        #region [- props -]
        public int TotalPrice
        {
            get
            {
                int totalprice = 0;
                foreach (var item in Ref_Product)
                {
                    totalprice = item.Price + totalprice;
                }
                return totalprice;
            }
        }
        public int Code { get; set; }
        public List<Product> Ref_Product { get; set; }
        public Person Seller { get; set; }
        public Person Buyer { get; set; } 
        #endregion

        #region [- ProductsInitializer() -]
        public void ProductsInitializer()
        {
            Ref_Product = new List<Product>();
        } 
        #endregion


    }
}
