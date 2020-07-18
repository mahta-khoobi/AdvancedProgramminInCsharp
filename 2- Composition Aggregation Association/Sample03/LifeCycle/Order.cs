using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class Order:Framework.Base.BaseOrder
    {
        #region [- ctor -]
        public Order(Framework.Interface.IPerson buyer, Framework.Interface.IPerson seller, int code) : base(buyer, seller, code)
        {

        } 
        #endregion
    }
}
