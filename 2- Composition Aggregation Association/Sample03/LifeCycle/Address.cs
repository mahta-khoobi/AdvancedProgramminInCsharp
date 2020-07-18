using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class Address:Framework.Base.BaseAddress
    {
        #region [- ctor -]
        public Address(Framework.Interface.ICity city, Framework.Interface.ICountry country, string street, int no) : base(city, country, street, no)
        {

        } 
        #endregion
    }
}
