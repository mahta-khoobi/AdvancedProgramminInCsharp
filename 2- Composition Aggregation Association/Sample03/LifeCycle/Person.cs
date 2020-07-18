using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.LifeCycle
{
    public class Person:Framework.Base.BasePerson
    {
        #region [- ctor -]
        public Person(string surname, string name, int code) : base(surname, name, code)
        {

        } 
        #endregion

      
        
    }
}
