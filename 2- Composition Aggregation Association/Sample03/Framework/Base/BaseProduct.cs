using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Base
{
    public class BaseProduct : Interface.IProduct
    {
        #region [- ctor -]
        public BaseProduct(int amount, int unitPrice, string name, int code)
        {
            Amount = amount;
            UnitPrice = unitPrice;
            Name = name;
            Code = code;
        } 
        #endregion


        #region [- props -]
        public int Amount { get; set; }
        public int UnitPrice { get; set; }
        public int Price { get { return Amount * UnitPrice; } }
        public string Name { get; set; }
        public int Code { get; set; } 
        #endregion
    }
}
