using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    
    public class C
    {
        #region [- ctor -]
        public C()
        {
            
        }

        #endregion
       

        public void PrintAge(Person ref_Person)
        {
            Console.WriteLine(ref_Person.Age);
        }
    }
    
   
}
