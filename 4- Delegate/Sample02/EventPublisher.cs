using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
     public class EventPublisher
    {
        public event PersonDelegate ShowDetailEvent;

        public void ShowDetails(Person ref_Person)
        {
            ShowDetailEvent(ref_Person);
        }
    }
}
