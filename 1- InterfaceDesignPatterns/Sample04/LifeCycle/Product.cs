using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.LifeCycle
{
    public class Product:Framework.Base.BaseProduct
    {
        #region [- ctor -]
        public Product(string name, int unitPrice, int count):base (name, unitPrice , count)
        {

        } 
        #endregion
    }
}
