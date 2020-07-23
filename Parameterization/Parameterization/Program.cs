using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parameter";
            double weight;
            string num;
            //Weight passed in by reference: (out keyword):
            num = getWeight(out weight);
            Console.WriteLine(num + " lb = " + lbToKg(weight) + " kg ");

            //Weight passed in For Output (ref keyword):
            kgToLb(ref weight);
            Console.WriteLine(num + " kg = " + weight + " lb ");
            Console.ReadKey();

        }

        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "ten";
        }

        static double lbToKg(double pounds = 5)
        {
            return (pounds * 0.45359237);
        }

        static  void kgToLb(ref double weight)
        {
            weight = (weight / 0.45359237);
        }

    }
}
