using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.classes
{
    internal class admin : person
    {
        public admin(string personId, string username, string password, string mobileNumber, string email) : base(personId, username, password, mobileNumber, email, "admin")
        {
        }
    }
}
