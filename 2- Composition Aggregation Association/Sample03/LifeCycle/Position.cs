using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class Position:Framework.Base.BasePosition
    {
        #region [- ctor -]
        public Position(string title, int authorityLevel) : base(title, authorityLevel)
        {

        } 
        #endregion
    }
}
