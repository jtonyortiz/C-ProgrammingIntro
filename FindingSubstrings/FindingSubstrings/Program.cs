using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finding Substrings";

            string text = "My dog is a cute dog";
            Console.WriteLine(text + "\tLength: " + text.Length);

            //Request user input in initialize another string variable
            //with a substring to seek:
            Console.WriteLine("\nPlease Enter A Substring To Seek: ");
            string sub = Console.ReadLine();

            //Character array to init another string variable with 
            //a substring to seek :
            char[] arr = new char[sub.Length];
            sub.CopyTo(0, arr, 0, sub.Length);

            //Seek the first occurrnce of the sibstring and call report method:
            int pos = text.IndexOf(sub);
            report(pos, sub);

            //Seek the last occurence of the substring and report result:
            pos = text.LastIndexOf(sub);
            report(pos, sub);

            //Seek the occurence of any char. of the substring, report result:
            pos = text.IndexOfAny(arr);
            report(pos, text.Substring(pos, 1));

            //Finally, seek the last occurence of any char. of the substring 
            //and report the result:
            pos = text.IndexOfAny(arr);
            report(pos, text.Substring(pos, 1));
            Console.ReadKey();

        }//end MAIN

        //Method: report()
        //Static method used to report the result of a
        //substring:
        static void report(int pos, string sub)
        {
            if (pos != -1)
                Console.WriteLine("'" + sub + " Found At: " + pos);
            else
                Console.WriteLine("" + sub + " Not Found!");
        }
    }
}
