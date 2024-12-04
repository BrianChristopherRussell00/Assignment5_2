using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    public class Palindrome
    {

        public static bool CheckIfPalindrome(string s)
        { 
 
                if (s.Length<=1)
                {
                return true;                    

                    

                }
            if (s[0] != s[s.Length-1])
                {
                return false;                    

                }
            return CheckIfPalindrome(s.Substring(1,s.Length-2));
            }

        }
    }

