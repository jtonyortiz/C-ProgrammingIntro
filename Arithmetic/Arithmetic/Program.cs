using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arithmetic";
            int a = 8;
            int b = 4;

            Console.WriteLine("Addition:\t" + (a + b));
            Console.WriteLine("Subtraction:\t:" + (a - b));
            Console.WriteLine("Multiplication:\t" + (a * b));
            Console.WriteLine("Division:\t" + (a / b));
            Console.WriteLine("Modulus:\t" + (a % b));

            //Postfix Increment Operation:
            Console.WriteLine("\nPostfix:\t:" + (a++));
            Console.WriteLine("Postfix Result....:\t" + a);

            //Prefix Increment Operation:
            Console.WriteLine("\nPrefix:\t:" + (++b));
            Console.WriteLine("Prefix Result....:\t:" + b);
            Console.ReadKey();


        }
    }
}
