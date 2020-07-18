using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.Framework.Interface
{
    public interface ISeller:IPerson
    {
         int Salary { get; set; }
    }
}
