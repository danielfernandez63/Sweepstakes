using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public  class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> SweepstakesQueue;

        public SweepstakesStackManager()
        {
            SweepstakesQueue = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepstakesQueue.Push(sweepstakes);
        }
         public Sweepstakes GetSweepstakes()
        {
            return SweepstakesQueue.Pop();
        }

    }
}
