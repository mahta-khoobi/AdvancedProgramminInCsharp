using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.Framework.Interface
{
    public interface IInvoice
    {
        #region [- props -]
        int Code { get; set; }
        int Discount { get; set; }
        int Tax { get; set; }
        int TotalCost { get;  }
        IProduct[] Products { get; set; }
        ICustomer Customer { get; set; }
        ISeller Seller { get; set; } 
        #endregion
    }
}
