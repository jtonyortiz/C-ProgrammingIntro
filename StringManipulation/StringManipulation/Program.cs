using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Manipulation";
            Console.Write("Please Enter Text: ");
            string text = Console.ReadLine();

            //Display user input string and report length:
            Console.Write("\nThanks. You Entered:\n" + text + "");
            Console.WriteLine("\t\tText Length: " + text.Length);

            //Remove leading and training whitespace
            //Then, dipslay the manipulated version and report its length:
            text = text.Trim();
            Console.Write("\nTrimmed:\t" + text + "");
            Console.WriteLine("\tText Length:" + text.Length);

            //Place string in upper-case lettering only:
            string upper = text.ToUpper();
            Console.WriteLine("\nUpper Case:\t" + upper + "");

            string lower = text.ToLower();
            Console.WriteLine("Lower Case:\t" + lower + "");

            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');

            //Observe Padded Whitespace:
            Console.WriteLine("\nPadded Left:\t" + upper + "");
            Console.WriteLine("Padded Right:\t" + lower + "");
            Console.WriteLine("Padded Both:\t" + text + "");

            //Trimmed Versions of the Strings:
            Console.WriteLine("Trimmed Start:\t" + upper.TrimStart() + "");
            Console.WriteLine("Trimmed End:\t" + text.TrimEnd('*') + "");
            Console.ReadKey();



        }
    }
}
