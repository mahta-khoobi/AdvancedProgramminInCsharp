using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IPerson
    {
        #region [- props -]
        int Code { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        string FullName { get; }
        #endregion

        #region [-ShowFullInfo()-]
        string ShowFullInfo(); 
        #endregion

    }
}
