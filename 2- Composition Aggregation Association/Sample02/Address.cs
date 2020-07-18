using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Address
    {
        #region [- ctor -]
        public Address(Country ref_Country , City ref_City,string street , int no)
        {
            Ref_Country = ref_Country;
            Ref_City = ref_City;
            Street = street;
            No = no;
        }
        #endregion

        #region [- props -]
        public string Street { get; set; }
        public int No { get; set; }
        public Country Ref_Country { get; set; }
        public City Ref_City { get; set; } 
        #endregion
    }
}
