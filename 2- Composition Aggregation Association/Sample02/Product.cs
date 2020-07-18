using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Product
    {
        #region [- ctor -]
        public Product(int code , string name , int amount , int unitPrice)
        {
            Code = code;
            Name = name;
            Amount = amount;
            UnitPrice = unitPrice;
        }
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }
        public int Price { get { return Amount * UnitPrice; }  }
        #endregion
    }
}
