using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class City:Framework.Base.BaseCity
    {
        #region [- ctor -] 
        public City(int code, string name) : base(code, name)
        {

        } 
        #endregion
    }
}
