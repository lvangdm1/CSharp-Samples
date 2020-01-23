using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    class Document : IStorable, IEncryptable
    {
        public void Decrypt()
        {
            Console.WriteLine("Decrypting");
        }

        public void Encrypt()
        {
            Console.WriteLine("Encrypting");
        }

        public void Load()
        {
            Console.WriteLine("Loading");
        }

        public void Save()
        {
            Console.WriteLine("Saving");
        }
    }
}
