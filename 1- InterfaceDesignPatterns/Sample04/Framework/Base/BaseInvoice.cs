using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample04.Framework.Interface;

namespace Sample04.Framework.Base
{
    public class BaseInvoice : Framework.Interface.IInvoice
    {
        #region [- ctor -]
        public BaseInvoice(int code, int discount, int tax, IProduct[] products, ICustomer customer, ISeller seller)
        {
            Code = code;
            Discount = discount;
            Tax = tax;
            Products = products;
            Customer = customer;
            Seller = seller;
        } 
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public int Discount { get; set; }
        public int Tax { get; set; }
        public int TotalCost
        {
            get
            {
                int totalCost = 0;
                foreach (var item in Products)
                {
                    totalCost = item.Price + totalCost;
                }
                totalCost = totalCost - (totalCost * (Discount / 100)) + (totalCost * (Tax / 100));
                return totalCost;

            }
        }
        public IProduct[] Products { get; set; }
        public ICustomer Customer { get; set; }
        public ISeller Seller { get; set; } 
        #endregion
    }
}
