using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
       
        Queue<Sweepstakes> SweeepstakesQueue;

        public SweepstakesQueueManager()
        {
            SweeepstakesQueue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweeepstakesQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
            {
            return SweeepstakesQueue.Dequeue();
            }

    }
}
