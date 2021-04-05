using System;

namespace DataTypesReview
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            DATA TYPES: int, double, char, string, bool
            VARIABLES: datatype variableName = value;
            COMMON ERRORS: wrong type, wrong value, no semicolon
            DATA TYPE CONVERSION: implicit, explicit, methods

            Good luck! */
            Console.WriteLine("Converts boolean to string:");
            bool is_true = true;
            Console.WriteLine($"This now prints: " + Convert.ToString(is_true));
            //Change a string to a list of characters:
            string hello = "Hello World!";
            Console.WriteLine($"This says: " + hello + "\nthis will print it as a list: ");
            char[] toCharArray = hello.ToCharArray();
            foreach(char ch in toCharArray){
                Console.WriteLine(ch);
            }
        }
    }
}
