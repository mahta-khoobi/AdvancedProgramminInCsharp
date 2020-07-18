using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Person
    {
        #region [- ctor -]
        public Person(int code , string name , string surname)
        {
            Code = code;
            Name = name;
            Surname = surname;

        }
        #endregion

        #region [- props -]
        public int Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Ref_Address { get; set; }
        public string FullInfo { get { return string.Format("code:{0} Name: {1} {2}",Code,Name,Surname); } }

        #endregion

        #region [- SetAddress(Address address) -]
        public void SetAddress(Address address)
        {
            Ref_Address = address;
        } 
        #endregion
        public Position GetPosition(string title , int authorityLevel)
        {
            return new Position(title,authorityLevel);
        }
    }
}
