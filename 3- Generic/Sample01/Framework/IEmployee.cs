using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public interface IEmployee<T,U>:IPerson<T>
    {
        U EmployeeCode { get; set; }
    }
}
