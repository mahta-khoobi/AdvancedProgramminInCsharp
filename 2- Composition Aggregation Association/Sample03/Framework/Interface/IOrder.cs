using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IOrder:Infrastructure.ICodedEntity
    {
        #region [- props -]
        int TotalPrice { get;}
        List<IProduct> Products { get; set; }
        IPerson Seller { get; set; }
        IPerson Buyer { get; set; }
        #endregion

        #region [- ProductsInitializer() -]
        void ProductsInitializer(); 
        #endregion

    }
}
