using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public interface IPerson<T>
    { 

        T Name { get; set; }
        T Surname { get; set; }
        T FullInfo();  


    }
}
