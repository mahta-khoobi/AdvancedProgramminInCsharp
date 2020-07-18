using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public interface IStudent<T,U>:IPerson<T>
    {
        U StudentCode  { get; set; }
    }
}
