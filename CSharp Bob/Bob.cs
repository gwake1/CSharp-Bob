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
                else if (msg.Contains("?"))
                {
                    return "Sure.";
                }
                else
                {
                    return "Whoa, chill out!";
                }
            }
            else if (msg.Contains("?"))
            {
                if (hasNumber)
                {
                    return "Sure.";
                }
                else if (ForceFulQuestion(msg, hasNumber))
                {
                    return "Whoa, chill out!";
                }
                else if (stateQuestion(msg))
                {
                    return "Whatever.";
                }
                else
                {
                    return "Sure.";
                }

            }
            else if (ForceFulQuestion(msg, hasNumber))
            {
                return "Whoa, chill out!";
            }
            else {
                return "Whatever.";
            }
        }

        private static bool stateQuestion(string msg)
        {
            int questionIndex = msg.IndexOf("?");
            char[] splitter = new char[] { '?' };
            string[] split = msg.Split(splitter);
            bool moreText = true;
            if (questionIndex < msg.Length - 1)
            {
                while (moreText)
                {
                    for (int i = 1; i < split.Length; i++)
                    {
                        string iter = split[i];
                        if (iter.Where(c => char.IsLetter(c)).Any())
                        {
                            moreText = true;
                        }
                        else
                        {
                            moreText = false;
                        }
                    }
                }
                if (moreText)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ForceFulQuestion(string msg, bool hasNumber)
        {
            string[] words = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string jumble = string.Concat(words);
            bool hasLower = jumble.Where(c => char.IsLower(c)).Any();
            if (hasLower)
            {
                return false;
            }
            else if (!hasLower  && !hasNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
