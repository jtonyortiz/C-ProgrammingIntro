using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingBaseConstructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calling Base Constructors";


            //Create instances of the derived classes:
            Daughter anna = new Daughter();
            Son brad = new Son();
            Son carl = new Son(100);
            Console.ReadKey();

        }
    }

    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Called");
        }

        //Overloaded constructor:
        public Parent(int num)
        {
            Console.WriteLine("Parent+ Called: " + num);
        }

    }

    //Daughter inherits parent:
    public class Daughter: Parent
    {
        public Daughter()
        {
            Console.WriteLine("\tDaughter Called\n");
        }
    }

    //Son inherits parent:
    public class Son: Parent
    {
        public Son()
        {
            Console.WriteLine("\tSon Called\n");
        }

        //Calling an overloaded constructor of the base class:
        public Son(int num): base(num)
        {
            Console.WriteLine("\tSon+ Called: " + num);
        }
    }

}
