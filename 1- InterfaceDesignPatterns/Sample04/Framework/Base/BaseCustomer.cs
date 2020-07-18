using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.Framework.Base
{
    public class BaseCustomer : Framework.Interface.ICustomer
    {
        #region [- ctor -]
        public BaseCustomer(int code, string firstName , string lastName)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        // public string ValidMessage { get; set; }
        private string validMessage;

        public string ValidMessage
        {
            get
            {
                if (validMessage != string.Empty)
                {
                    return validMessage;
                }
                else
                {
                    return validMessage = "everything is ok!";
                }
            }
            set { validMessage = value; }
        }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public string FullInfo { get { return string.Format("{0} {1} {2}", Code, FullName, Age); } } 
        #endregion
    }
}
