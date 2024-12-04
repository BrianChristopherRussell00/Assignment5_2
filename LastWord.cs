using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    public class LastWord
    {

        public static string checkLength(string s)
        {
            string[] words = s.Split(' ');
            return words[words.Length - 1];

        }
        public static int LengthOfLastWord(string s)
            {
            
                int i = s.Length - 1;
                while (i >= 0 && s[i] == ' ')
                {
                    --i;
                }
                int j = i;
                while (j >= 0 && s[j] != ' ')
                {
                
                    --j;
            }
            int difference = i - j;
            return difference;
        }

        


    }
}
