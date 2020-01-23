using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStrings
{
    class Literals
    {
        public string MyLiterals(string s1, string s2, string s3, string s4)
        {
            
            s1 = "hello"; // string literal
            s2 = @"hello";  // verbatim string literal
            s3 = $"hello";  // interpolated string literal

            s4 = @"Select productName, 
            Price from Products 
            where Price > 21";
            var results = (s1 +"\r\n" + s2 + "\r\n" +s3  +"\r\n" +s4);
            return results;
        }
    }
}
