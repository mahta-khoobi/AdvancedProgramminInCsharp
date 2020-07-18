using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Lifecycle
{
    public class Worker:Framework.Base.BaseEmployee
    {
        #region [- ctor -]
        public Worker(string name, string surname, int salary) : base(name, surname, salary)
        {

        } 
        #endregion
    }
}
