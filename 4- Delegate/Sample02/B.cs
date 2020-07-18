using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class B
    {
        #region [- ctor -]
        public B()
        {
            
        }
        #endregion
        

        public void PrintSurname(Person ref_Person)
        {
            Console.WriteLine(ref_Person.Surname);
        }
    }
}
