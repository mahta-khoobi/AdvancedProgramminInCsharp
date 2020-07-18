using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Base
{
    public class BaseStudent : Interface.IStudent
    {
        #region [- ctor -]
        public BaseStudent(string name , string surname)
        {
            Name = name;
            Surname = surname;
        }
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }
        #endregion

        #region [- ShowFullInfo() -]
        public string ShowFullInfo()
        {
            return string.Format("Name :{0} Age :{1} Code:{2} ", FullName, Age, Code);
        } 
        #endregion
    }
}
