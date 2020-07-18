using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Position
    {
        #region [- ctor -]
        public Position(string title , int authorityLevel)
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
