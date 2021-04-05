using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel{
                FirstName = "James",
                LastName = "Ortiz"
            };

            System.Console.WriteLine($"{p.FirstName} {p.LastName} is my name.");
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("This is a test");
            System.Console.WriteLine("The end.");
        }
    }
}
