using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.Framework.Base
{
    public class BaseProduct : Framework.Interface.IProduct
    {
        #region [- ctor -]
        public BaseProduct(string name, int unitPrice, int count)
        {
            Name = name;
            UnitPrice = unitPrice;
            Count = count;
        }
        #endregion

        #region [- props -]

        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Count { get; set; }
        public int Price { get { return Count * UnitPrice; } } 
        #endregion
    }
}
