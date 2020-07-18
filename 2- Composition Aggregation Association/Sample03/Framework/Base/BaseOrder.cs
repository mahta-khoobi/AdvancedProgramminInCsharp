using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample03.Framework.Interface;

namespace Sample03.Framework.Base
{
    public class BaseOrder : Interface.IOrder
    {
        #region [- ctor -]
        public BaseOrder(IPerson buyer , IPerson seller , int code)
        {
            Code = code;
            Buyer = buyer;
            Seller = seller;
        } 
        #endregion

        #region [- props -]
        public int TotalPrice
        {
            get
            {
                int totalprice = 0;
                foreach (var item in Products)
                {
                    totalprice = item.Price + totalprice;
                }
                return totalprice;
            }
        }
        public List<IProduct> Products { get; set; }
        public IPerson Seller { get; set; }
        public IPerson Buyer { get; set; }
        public int Code { get; set; } 
        #endregion

        #region [- ProductsInitializer() -]
        public void ProductsInitializer()
        {
            Products = new List<IProduct>();
        } 
        #endregion
    }
}
