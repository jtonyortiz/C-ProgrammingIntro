using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Condition";

            int a = 8;
            int b = 3;

            string verb = (a != 1) ? " are " : " is ";
            Console.Write("There" + verb + a + "\n");

            //Checking a parity of a string:
            string parity = (a % 2 != 0) ? "Odd" : "Even";
            Console.Write(a + " is " + parity + "\n");

            parity = (b % 2 != 0) ? "Odd" : "Even";
            Console.Write(b + " is " + parity + "\n");

            //Add statement to output a string reporting the greater value 
            //of the two variables:
            int max = (a > b) ? a : b;

            Console.Write("\nMaximum is " + max);
            Console.ReadKey();
        }
    }
}
