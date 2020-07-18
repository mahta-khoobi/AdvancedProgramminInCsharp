using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IProduct:Infrastructure.INamedEntity
    {
        
        
        #region [-props-]
        int Amount { get; set; }
        int UnitPrice { get; set; }
        int Price { get; } 
        #endregion
    }
}
