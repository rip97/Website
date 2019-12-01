using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Comment { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string TypeOfRequest { get; set; }

        public bool IsWebApp { get; set; }

        public bool IsWindowsApp { get; set; }

        public bool IsPhoneApp { get; set; }

        public bool Quote { get; set; }

        public bool GeneralMessage { get; set; }


    }
}
