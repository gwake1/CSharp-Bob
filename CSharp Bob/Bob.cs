using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Bob
{
    public class Bob
    {
        public static string Hey(string msg)
        {
            if (msg.Contains("!"))
            {
                return "Whoa, chill out!";
            }
            else if (msg.Contains("?"))
            {
                return "Sure.";
            }
            return "Whatever.";
        }
    }
}
