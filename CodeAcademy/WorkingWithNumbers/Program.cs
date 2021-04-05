using System;

namespace WorkingWithNumbers
{
    class Program
    {
         static void Main(string[] args)
        {
                            /* use this space to write your own short program! 
                Here's what you learned:

                DATA TYPES: int, double
                ARITHMETIC OPERATORS: +, -, *, /
                INCREMENT/DECREMENT: ++, --
                MODULO: % 
                BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max
                Good luck! */

                //Formula for compound interest
                //A = P(1 + r/n)^(n*t)
                double final_amt;
                //Initial Principal Balance

                //r = interest rate
                double r = 3.95;
                //n = number of times interest applied per time period
                double n = 2;
                //t = number of time periods elapsed
                double t = 4;

                //total:
                final_amt = Math.Pow((1 + r/n), n*t);

                Console.WriteLine($"The total compunded amount is the following: " + final_amt);

                //Find age in human years, given dog years:
                //Formula: 16 * ln(dogyears) + 31
                double dog_years = 5.0;
                dog_years = 16 * Math.Log(dog_years) + 31;
                Console.WriteLine("The years in human years is: " + dog_years);


        }
    }
}
