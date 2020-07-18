using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.LifeCycle
{
    public class Invoice:Framework.Base.BaseInvoice
    {
        #region [- ctor -]
        public Invoice(int code, int discount, int tax, Framework.Interface.IProduct[] products, Framework.Interface.ICustomer customer, Framework.Interface.ISeller seller) : base(code, discount, tax, products, customer, seller)
        {


        } 
        #endregion
    }
}
