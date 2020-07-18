using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Person
    {
        #region [ - FName - ]
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        #endregion

        #region [ - LName - ]
        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        #endregion

        #region [ - Age - ]
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        #endregion
    }
}
