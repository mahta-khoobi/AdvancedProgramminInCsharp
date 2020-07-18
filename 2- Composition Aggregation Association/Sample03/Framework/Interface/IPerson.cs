using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface
{
    public interface IPerson: Infrastructure.INamedEntity
    {
        #region [- props -]
        string Surname { get; set; }
        IAddress Address { get; set; }
        #endregion

        #region [- SetAddress(IAddress address) -]
        void SetAddress(IAddress address);
        #endregion;

        IPosition GetPosition(string title, int authorityLevel);

        
    }
}
