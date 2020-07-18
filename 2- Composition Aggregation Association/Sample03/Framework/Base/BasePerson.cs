using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample03.Framework.Interface;

namespace Sample03.Framework.Base
{
    public class BasePerson : Interface.IPerson
    {
        #region [- ctor -]
        public BasePerson(string surname, string name, int code)
        {
            Surname = surname;
            Name = name;
            Code = code;
        } 
        #endregion

        #region [- props -]
        public string Surname { get; set; }
        public IAddress Address { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        #endregion

        #region [- SetAddress(IAddress address) -]
        public void SetAddress(IAddress address)
        {
            Address = address;
        }
        #endregion

        public IPosition GetPosition(string title , int authorityLevel)
        {
            return new BasePosition(title,authorityLevel);
        }

       
    }
}
