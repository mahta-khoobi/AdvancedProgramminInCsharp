using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Lifecycle
{
    public class Student:Framework.Base.BaseStudent
    {
        #region [- ctor -]
        public Student(string name, string surname) : base(name,surname)
        {

        } 
        #endregion
    }
}
