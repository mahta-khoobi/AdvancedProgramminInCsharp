using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Base
{
    public class BasePosition : Interface.IPosition
    {
        #region [- ctor -]
        public BasePosition(string title, int authorityLevel)
        {
            Title = title;
            AuthorityLevel = authorityLevel;
        } 
        #endregion


        #region [- props -]
        public string Title { get; set; }
        public int AuthorityLevel { get; set; } 
        #endregion
    }
}
