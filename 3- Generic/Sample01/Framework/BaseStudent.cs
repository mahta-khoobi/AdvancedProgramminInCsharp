using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public class BaseStudent : IStudent<string, int>
    {
        #region [- ctor -]
        public BaseStudent(int studentCode, string name, string surname)
        {
            StudentCode = studentCode;
            Name = name;
            Surname = surname;
        }
        #endregion

        #region [- props -]
        public int StudentCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        #endregion

        #region [- FullInfo() -]
        public string FullInfo()
        {
            return string.Format("{0} {1} {2}", StudentCode, Name, Surname);
        }
        #endregion
    }
}
