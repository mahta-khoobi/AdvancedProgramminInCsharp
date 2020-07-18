using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public class BaseEmployee : IEmployee<string,int>
    {
        #region [- ctor -]
        public BaseEmployee(int employeeCode, string name, string surname)
        {
            EmployeeCode = employeeCode;
            Name = name;
            Surname = surname;
        } 
        #endregion

        #region [- props -]
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        #endregion

        #region [- FullInfo() -]
        public string FullInfo()
        {
            return string.Format("{0} {1} {2}", EmployeeCode, Name, Surname);
        } 
        #endregion
    }
}
