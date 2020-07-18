using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class A

    {
        #region [- ctor -]
        public A()
        {
        }
        #endregion

       

        public void PrintName(Person ref_Person)
        {
            Console.WriteLine(ref_Person.Name);
        }
    }
}
