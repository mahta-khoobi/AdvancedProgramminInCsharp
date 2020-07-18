using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class Country:Framework.Base.BaseCountry
    {
        #region [- ctor -]
        public Country(int code, string name) : base(code, name)
        {

        } 
        #endregion
    }
}
