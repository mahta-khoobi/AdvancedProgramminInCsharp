using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.LifeCycle
{
    public class Customer:Framework.Base.BaseCustomer
    {
        #region [- ctor -]
        public Customer(int code, string firstName, string lastName) : base(code, firstName, lastName)
        {

        } 
        #endregion
    }
}
