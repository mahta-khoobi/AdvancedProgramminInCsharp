using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.LifeCycle
{
    public class Teacher:Framework.BaseEmployee
   
    {
        #region [ ctor -]
        public Teacher(int employeeCode, string name, string surname) : base(employeeCode, name, surname)
        {

        } 
        #endregion
    }
}
