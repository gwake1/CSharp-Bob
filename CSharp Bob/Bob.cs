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
            bool hasNumber = msg.Where(c => char.IsDigit(c)).Any();
            if (msg.Contains("!"))
            {
                if (msg.Contains("Let's"))
                {
                    return "Whatever.";
                }
                else
                {
                    return "Whoa, chill out!";
                }
            }
            else if (msg.Contains("?")  || hasNumber)
            {
                return "Sure.";
            }
            return "Whatever.";
        }
    }
}
