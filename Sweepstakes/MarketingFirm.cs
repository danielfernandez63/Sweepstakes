using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public  class MarketingFirm
    {
       
       public ISweepstakesManager sweepstakeStorage;
        
        
        public MarketingFirm(ISweepstakesManager style)
        {
          this.sweepstakeStorage = style;
            InputSweepstakes();
            UpdateSweepstake();
        }

        public void InputSweepstakes()
        {
            string sweepstakeName = UI.GetSweepstakeName();
            Sweepstakes thisSweepstake = new Sweepstakes(sweepstakeName);
            Add(thisSweepstake);
        }
        
        public void Add(Sweepstakes sweepstakes)
        {          
            sweepstakeStorage.InsertSweepstakes(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakeStorage.GetSweepstakes();
        }

        public void UpdateSweepstake()
        {
            Sweepstakes currentSweepstake = GetSweepstakes();
            bool updateSweepstake = UI.UpdateCurrentSweepStake(currentSweepstake);
            if (updateSweepstake)
            {
                int newContestants = UI.NewContestants(currentSweepstake);
                for (int i = 0; i <newContestants; i ++)
                {
                    Contestant newContestant = new Contestant();
                    currentSweepstake.RegisterContestant(newContestant);
                    Console.WriteLine("");
                    Console.WriteLine("Contestant Added");
                    Console.ReadLine();
                }
                PickWinner(currentSweepstake);    
            }

        }

        public void PickWinner(Sweepstakes currentSweepstake)
        {
            bool pickWinner = UI.PickWinner(currentSweepstake);
            if (pickWinner)
            {
                Contestant winnner = currentSweepstake.PickWinner();
                currentSweepstake.PrintContestantInfo(winnner);
                Console.ReadLine();
            }

        }










    }
}
