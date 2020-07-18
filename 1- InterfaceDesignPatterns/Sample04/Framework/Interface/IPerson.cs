using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04.Framework.Interface
{
    public interface IPerson
    {
        #region [- props -]
        int Code { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string ValidMessage { get;  set; }
        string FullName { get;  }
        string FullInfo { get;  } 
        #endregion

    }
}
