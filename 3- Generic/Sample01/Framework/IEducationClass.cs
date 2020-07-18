using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public interface IEducationClass<T,U,V,W, K, M, N> where K : IEmployee<T, U>
                                               where M : IStudent<V, W>
                                               where N : struct
    {
        K Trainer { get; set; }
        List<M> Students { get; set; }
        N TotalCost { get; }
        N UnitCost { get; set; }
        void AddStudent(M item);
        void ShowListOfStudents();

       


    }
}
