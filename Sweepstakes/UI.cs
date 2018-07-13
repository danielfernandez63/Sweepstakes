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
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }
        public static string GetFullName()
        {
            string name = GetFirstName() + GetLastName();
            return name;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your current email address?");
            return Console.ReadLine();
        }

        public static string GetEmailAdress()
        {
            Console.WriteLine("What is dyour current email adress?");
            return Console.ReadLine();
        }

        public static ISweepstakesManager GetMarketingFirmStylePreference()
        {
            Console.WriteLine("Thank you for starting the Sweepstakes Application!Follow instructions as they appear");
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




        
       
    }
}
