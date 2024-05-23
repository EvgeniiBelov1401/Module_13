using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_04_04
{
    internal class Contact
    {
        public long phoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(long number,string email)
        {
            phoneNumber = number;
            Email = email;
        }
    }
}
