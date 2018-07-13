using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public  class MarketingFirm
    {
        //impliment dependancy injection from the sweepstakes manager
        ISweepstakesManager sweepstakeStorage;
        
        public MarketingFirm(ISweepstakesManager style)
        {
            this.sweepstakeStorage = style;

        }











    }
}
