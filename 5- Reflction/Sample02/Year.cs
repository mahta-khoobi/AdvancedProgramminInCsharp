using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Year
    {
        #region [ - StartDate - ]
        private int startDate;

        public int StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        #endregion

        #region [ - EndDate - ]
        private int endDate;

        public int EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        #endregion
    }
}
