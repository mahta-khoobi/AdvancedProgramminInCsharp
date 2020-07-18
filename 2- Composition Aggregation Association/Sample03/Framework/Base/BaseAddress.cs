using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample03.Framework.Interface;

namespace Sample03.Framework.Base
{
    public class BaseAddress : Interface.IAddress
    {
        #region [- ctor -]
        public BaseAddress(ICity city, ICountry country, string street, int no)
        {
            City = city;
            Country = country;
            Street = street;
            No = no;
        } 
        #endregion


        #region [- props -]
        public ICity City { get; set; }
        public ICountry Country { get; set; }
        public string Street { get; set; }
        public int No { get; set; } 
        #endregion
    }
}
