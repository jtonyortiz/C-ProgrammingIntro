using System;

namespace InputPractice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            //Reads input from user:
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
        }
    }
}
