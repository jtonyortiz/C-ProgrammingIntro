using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recursive Code Examples";

            //Calculate Factorials from 1 to 10:
            computeFactorials(1, 10);
            Console.ReadKey();

        }

        static int factorial(int num)
        {
            //Finding the factorial useing the ternary operator:
            return (num == 1) ? 1: (factorial(num - 1) * num);
        }

        static void computeFactorials(int num, int max)
        {
            while(num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(factorial(num));
                num++;
            }
        }



    }
}
