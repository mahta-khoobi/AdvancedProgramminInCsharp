using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.Framework.Interface
{
    public interface IProduct
    {
        #region [- props -]
        string Name { get; set; }
        int UnitPrice { get; set; }
        int Count { get; set; }
        int Price { get; } 
        #endregion
    }
}
