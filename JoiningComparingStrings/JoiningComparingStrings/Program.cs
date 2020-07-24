using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningComparingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Joining and Comparing Strings";

            string[] a = new string[3] { "Alpha", "Bravo", "Charlie" };
            //Assign a concatenated version of the first two array values 
            //to a tring variable and display value:
            string s = String.Concat(a[0], a[1]);
            Console.WriteLine("Concatenated:\t" + s);


            //Joined version of the first two array elements:
            s = String.Join(" ", a[0], a[1]);
            Console.WriteLine("Joined:\t\t" + s);

            //Asign a joined version of all three array elements 
            //for alphabetic order:
            s = string.Join("<br>", a);
            Console.WriteLine("\nHTML:\t" + s + "\n");

            //Compare all 3 elements in alphabetic order:
            int num = String.Compare(a[0], a[1]);
            Console.WriteLine(a[0] + " v " + a[1] + ":\t" + num);

            num = String.Compare(a[2], a[1]);
            Console.WriteLine(a[2] + " v " + a[1] + ":\t" + num);

            num = a[1].CompareTo(a[1]);
            Console.WriteLine(a[1] + " v " + a[1] + ":\t" + num + "\n");

            //Finally, test array values for equality:
            bool flag = (a[0] == a[1]);
            Console.WriteLine(a[0] + " == " + a[1] + ":\t\t" + flag);
            flag = a[2].Equals(a[2]);
            Console.WriteLine(a[2] + " == " + a[2] + ":\t\t" + flag);
            Console.ReadKey();
        }
    }
}
