using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartIalClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of the Sailboat class:
            Sailboat boat = new Sailboat("Laser", "Classic");
            boat.describe();
            Console.ReadKey();
        }
    }

    //Part of the same namespace, hence the term "partial classes":
    public partial class Sailboat
    {
        public void describe()
        {
            Console.WriteLine("Sailboat: {0} {1}", make, model);
        }
    }
}
