using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IPosition:Infrastructure.IEntity
    {
        #region [- props -]
        string Title { get; set; }
        int AuthorityLevel { get; set; } 
        #endregion
    }
}
