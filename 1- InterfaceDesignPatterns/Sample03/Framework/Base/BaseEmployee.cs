using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Base
{
    public class BaseEmployee : Interface.IEmployee
    {
        #region [- ctor -]
        public BaseEmployee(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }

        public int Salary { get; set; }
        #endregion

        #region [- ShowFullInfo() -]
        public string ShowFullInfo()
        {
            return string.Format("Name :{0} Age :{1} Code:{2} Salary:{3}", FullName, Age, Code, Salary);
        } 
        #endregion
    }
}
