using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string name;
        public string emailAddress;
        private int registrationNumber = 0; 

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }

        }

        public Contestant()
        {
            name = UI.GetFullName();
            emailAddress = UI.GetEmailAddress();
            this.registrationNumber = RegistrationNumber;

        }

    }
}
