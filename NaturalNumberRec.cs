using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    public class NaturalNumberRec
    {
        public static int printNatural(int ctr, int startingValue)
        {
            // Base case: If the counter becomes less than 1, return the starting value
            if (ctr < 1)
            {
                return startingValue;
            }

            Console.Write(" {0} ", ctr); // Print the current number
            ctr--; // Decrement the counter
                   // Recursive call: Decrement 'ctr' and continue printing natural numbers
            return printNatural(ctr, startingValue);
        }
    }
}
