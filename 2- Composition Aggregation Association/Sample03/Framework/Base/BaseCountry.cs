using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Base
{
    public class BaseCountry : Interface.ICountry
    {
        #region [- ctor -]
        public BaseCountry(int code, string name)
        {
            Code = code;
            Name = name;

        } 
        #endregion


        #region [- props -]
        public string Name { get; set; }
        public int Code { get; set; } 
        #endregion
    }
}
