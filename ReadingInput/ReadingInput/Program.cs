using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Input";
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + "!");

            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            //Convert to Integer:
            int num = Convert.ToInt32(number);

            Console.Write("The number that is inputted was: " + num);
            Console.ReadKey();
        }
    }
}
