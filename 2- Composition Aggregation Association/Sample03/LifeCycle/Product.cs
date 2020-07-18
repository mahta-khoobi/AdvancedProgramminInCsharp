using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class Product:Framework.Base.BaseProduct
    {
        #region [- ctor -]
        public Product(int amount, int unitPrice, string name, int code) : base(amount, unitPrice, name, code)
        {

        } 
        #endregion
    }
}
