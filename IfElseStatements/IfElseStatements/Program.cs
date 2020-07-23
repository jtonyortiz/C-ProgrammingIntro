using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "If-Else Statements";

            Console.Write("Please enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks! Now, enter a letter..");
            char letter = Convert.ToChar(Console.ReadLine());

            //If-else statement:
            if(num >= 6)
            {
                Console.WriteLine("\nNumber Exceeds 5");
            }
            else
            {
                Console.WriteLine("\nNumber is 5 or less");
            }
            Console.ReadKey();


            if(letter == 'C')
            {
                Console.WriteLine("Letter is C.");

            }
            Console.ReadKey();


        }
    }
}
