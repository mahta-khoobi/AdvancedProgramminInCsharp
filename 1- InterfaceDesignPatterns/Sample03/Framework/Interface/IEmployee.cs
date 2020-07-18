using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IEmployee:IPerson
    {
         int Salary { get; set; }
         
    }
}
