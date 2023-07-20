using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator_Object
{
    public class Validator
    {
        public static double DoubleValidator()
        {
            double input = 0;
            while (true)
            {
                while (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input: Do not use numbers or symbols.");
                }
                if (input > 0)
                {
                    
                    return input;
                }
                else
                {
                    Console.WriteLine("Try again: Only positive numbers.");
                }
            }                    
        }
        public static bool Continue()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower().Trim();
                
                if("yes".Contains(input))
                {
                    return true;
                }
                else if ("no".Contains(input))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input: Use y/n.");
                }
            }
        }
    }
}
