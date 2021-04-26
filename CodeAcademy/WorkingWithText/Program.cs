using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
               Here's what you learned:

                DATA TYPES: char, string
                STRING INTERPOLATION: $"blah blah"
                STRING INFO: .Length, .IndexOf()
                PARTS OF STRINGS: bracketNotation[], .Substring() 
                 STRING MANIPULATION: .ToUpper(), .ToLower()

                 Good luck! */

                    string name_;
                    Console.Write("Please enter name of character: ");
                    name_ = Console.ReadLine();

                    string topic_;
                    Console.WriteLine("Please enter topic of the story: ");
                    topic_ = Console.ReadLine();

                    string storyLine = $"This is a story about {name_}, and it is short but {topic_} packed.";

                    Console.WriteLine(storyLine);
        }
    }
}
