using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Country
    {
        #region [- ctor -]
        public Country(int code, string name)
        {
            Code = code;
            Name = name;
        } 
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public string Name { get; set; } 
        #endregion
    }
}
