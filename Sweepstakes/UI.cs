using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UI
    {

        public static string GetFirstName()
        {
            Console.Clear();
            Console.WriteLine("What is current registering contestants first name?");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("");
            Console.WriteLine("What is current registering contestant's last name?");
            return Console.ReadLine();
        }
        public static string GetFullName()
        {
            string name = GetFirstName() + " " + GetLastName();
            return name;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("");
            Console.WriteLine("What is current registering contestant's  email address?");
            return Console.ReadLine();
        }

        public static ISweepstakesManager GetMarketingFirmStylePreference()
        {
            Console.WriteLine("Thank you for starting the Sweepstakes Application!Follow instructions as they appear");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like the system to be set up in a stack or queue style? Please select 'stack' or 'queue'.");
            string style = Console.ReadLine().ToString().Trim();

            if (style == "stack")
            {
                SweepstakesStackManager stackStyle = new SweepstakesStackManager();
                return stackStyle;
            }
            else if (style == "queue")
            {
                SweepstakesQueueManager queueStyle = new SweepstakesQueueManager();
                return queueStyle;
            }
            else
            {
                Console.WriteLine("Please follow directions and enter a valid input");
                Console.ReadLine();
                return GetMarketingFirmStylePreference();            
            }
        }

        public static string GetSweepstakeName()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What would you like to name the current contest?");
            return Console.ReadLine();
        }

        public static bool UpdateCurrentSweepStake(Sweepstakes sweepstakes)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like to update the sweepstake named " + sweepstakes.name  + " and add more contestants, or would you like to end the contest? Please make sure to add contestants first or start over. Please type 'add' or 'end'.");
            string answer = Console.ReadLine().ToLower().Trim();
            bool update = false;
          switch (answer)
            {
                case "add":
                    update = true;
                    break;

                case "end":           
                    update = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid answer.");
                    Console.ReadLine();
                    UpdateCurrentSweepStake(sweepstakes);
                    break;
            }

            return update;

        }

        public static int NewContestants(Sweepstakes sweepstakes)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("How many contestant would you like to add to the current sweepstake named" + sweepstakes.name + "?  Please respond with a digit as an answer like 3 or 6.");
            int newContestants = Int32.Parse(Console.ReadLine());
            return newContestants;
        }

        public static bool PickWinner(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Are you sure that you want to pick a winner? Please enter 'yes' or 'no'.");
            string answer = Console.ReadLine().ToLower().Trim();
            bool pickWinner = false;
            switch (answer)
            {
                case "yes":
                    pickWinner = true;
                    break;

                case "no":
                    pickWinner = false;
                    NewContestants(sweepstakes);
                    break;
                default:
                    Console.WriteLine("Please enter a valid answer.");
                    Console.ReadLine();
                    PickWinner(sweepstakes);
                    break;
            }
            return pickWinner;
        }
    }
}
