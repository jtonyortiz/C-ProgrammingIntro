using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Features";

            Console.Write("Please Enter Text:");
            string text = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nERROR: No Text Found!");
            }
            else
            {
                Console.WriteLine("\nThanks. You entered:\n" + text + "");
                Console.WriteLine("\nText Length: " + text.Length);

                //Check how the string begins:
                string query = text.StartsWith("C#") ? " Does" : " Does Not";
                Console.WriteLine("Text" + query + "Start with C#");

                //Test how the strng ends:
                query = text.EndsWith("steps") ? " Does" : " Does Not";
                Console.WriteLine("Text" + query + " End with 'steps'");

                //Test what the string contains:
                query = text.Contains("easy") ? " Does" : " Does Not";
                Console.WriteLine("Text" + query + " contains easy");
            }
            Console.ReadKey();
        }
    }
}
