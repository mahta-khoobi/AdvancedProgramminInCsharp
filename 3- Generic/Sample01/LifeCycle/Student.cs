using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.LifeCycle
{
    public class Student:Framework.BaseStudent
    {
        #region [- ctor -]
        public Student(int studentCode, string name, string surname) : base(studentCode, name, surname)
        {

        } 
        #endregion
    }
}
