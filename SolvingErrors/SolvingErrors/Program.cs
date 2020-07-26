using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] nums = new int[10];
            for (int i = 1; i < 20; i++)
                nums[i] = i;
                */

            /*
            int pass = 0;
            int unit = 2;

            for(int i = 1; i < 3; i++)
            {
                pass = (pass + 1);
                unit = square(unit);
            }
            */

            Console.Write("Please Enter A Number: ");
            double num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Now Enter Antoher Number: ");
            double num2 = Convert.ToInt16(Console.ReadLine());
        }

        static int square(int num)
        {
            return (num * num);
        }
    }
}