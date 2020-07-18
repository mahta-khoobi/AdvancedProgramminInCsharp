using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03.Framework.Interface.Infrastructure
{
    public interface INamedEntity:ICodedEntity
    {
         string Name { get; set; }
    }
}
