using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Student: Human
    {
        public string StudentName { get; set; }

        public override string SendMessage(string message)
        {
            //Virtual method: this is the text to be used.
            var originalmsg = base.SendMessage(message);
            var msg = new StringBuilder(originalmsg);

            msg.AppendLine(" dude");
            return msg.ToString();
        }
    }
}
