using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IAddress
    {
        #region [- props -]
        ICity City { get; set; }
        ICountry Country { get; set; }
        string Street { get; set; }
        int No { get; set; } 
        #endregion
    }
}
