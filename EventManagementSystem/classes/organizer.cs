using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.classes
{
    internal class organizer : person
    {
        public organizer(string personId, string username, string password, string mobileNumber, string email ) : base(personId, username, password, mobileNumber, email, "organizer")
        { 
        }
    }
}
