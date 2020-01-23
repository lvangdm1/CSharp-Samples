using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Virtual method to get text.
        public virtual string SendMessage(string message)
        {
            return message;
        }
    }
}
