using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public  class Sweepstakes
    {
        public string name;
        public int contestants = 0;
        public Dictionary<int, Contestant> contestantNumber;
        public int winnerKey;
        Random rnd = new Random();

        Sweepstakes(string name)
        {
            contestantNumber = new Dictionary<int, Contestant>();
           
            this.name = name;
        }

    	public void RegisterContestant(Contestant contestant)
        {          
            contestantNumber.Add(contestants, contestant);
            contestants++;
        }

        public Contestant PickWinner()
        {
            int winningNumber = rnd.Next(0, contestants);
            foreach (KeyValuePair<int, Contestant> contestant in contestantNumber)
            {
                if (contestant.Key == winningNumber)
                {
                    winnerKey = winningNumber;
                    return contestant.Value;
                }

            }

            return null;
        }
        
	    public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Without further ado! The winner has been selected and will be revealed");
            Console.WriteLine("");
            Console.WriteLine("The winner is....");
            Console.WriteLine("DDDDDDDRRRRRRRRRUUUUUMMMMMMRRRRRRROOOOOOLLLLLLL!!!!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Name: " + contestant.name);
            Console.WriteLine("");
            Console.WriteLine("Email Address: " + contestant.emailAddress);
            Console.WriteLine("");
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber);
            Console.WriteLine("");
            Console.WriteLine("If you are the winner, please bring identifcation and original reciept with reference number to the service desk to receive details on claiming your prize. If you did not win please try again " +
                "in future contests.");

        }


    }
}
