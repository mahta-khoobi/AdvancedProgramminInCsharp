using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.LifeCycle
{
    public class Seller:Framework.Base.BaseSeller
    {
        #region [- ctor -]
        public Seller(int code, string firstName, string lastName, int salary) : base(code, firstName, lastName, salary)
        {

        } 
        #endregion
    }
}
