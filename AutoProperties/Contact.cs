using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Contact
    {
        // Externally mutable properties
        public string Name { get; set; }
        public string Address { get; set; }

        // Read-only properties
        public int PhoneNumber { get; private set; }
        public string PostalCode { get; private set; }

        public Contact(string contactName, string contactAddress)
        {
            Name = contactName;
            Address = contactAddress;
        }
    }
}
