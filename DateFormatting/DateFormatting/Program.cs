using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Date & Time Formatting";
            //Init DateTime Object and dispaly value:
            DateTime now = DateTime.Now;

            Console.Write("Current Date And Time: " + now);

            Console.Write("\nDay Name: " + now.DayOfWeek);
            Console.Write("\nDate Only: " + now.ToShortDateString());
            Console.Write("\nTime Only: " + now.ToShortTimeString());

            now = now.AddYears(4);
            Console.Write("\n\nFuture Date: " + now);

            //Now create a new DateTime Obj, and display value:
            DateTime dt = new DateTime(2017, 7, 4, 8, 15, 30);
            Console.Write("\n\nSet Date And Time: {0:f}", dt);

            //Display specific components of the new DateTime object:
            Console.Write("\nDate Name: {0:dddd}", dt);
            Console.Write("\nLong Date: {0:D}", dt);
            Console.Write("\nLong Time: {0:T}", dt);
            Console.ReadKey();

        }
    }
}
