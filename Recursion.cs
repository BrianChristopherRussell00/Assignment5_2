using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    public class Recursion
    {
        public static void FirstTen(int num)
        {
            
            
            while (num <= 10)
            {
                Console.WriteLine("{0} ", num);
                num++;
                break;
            }
            FirstTen(num);
            

        }

    }
}
