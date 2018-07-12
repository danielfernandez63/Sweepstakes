using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UI
    {

        public string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }
        public string GetFullName()
        {
            string name = GetFirstName() + GetLastName();
            return name;
        }

        public string GetEmailAddress()
        {
            Console.WriteLine("What is your current email address?");
            return Console.ReadLine();
        }

        public string GetEmailAdress()
        {
            Console.WriteLine("What is dyour current email adress?");
            return Console.ReadLine();
        }

        //method to ask and return how they want to "search' through contestants stack or queue. first in first our etc etc... probably static interface 'set'

       
    }
}
