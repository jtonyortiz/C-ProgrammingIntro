//
//Author: James Anthony Ortiz
//Description: Mad-Libs program example with C#
//


using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
                /*
                This program create a madlibs story 
                Author: James Anthony Ortiz
                Date: 04/11/2021
                */


                // Let the user know that the program is starting:
                Console.WriteLine("Program is beginning...");
                Console.WriteLine("Loading program...");

                // Give the Mad Lib a title:
                string title = "MadLibsStory";

                Console.WriteLine(title);
                // Define user input and variables:

                string name;
                Console.Write("Please enter a name: \n");
                name = Console.ReadLine();

                string adj1;
                Console.Write("Please enter a one adjective: \n");
                adj1 = Console.ReadLine();

                string adj2;
                Console.Write("Please enter another adjective: \n");
                adj2 = Console.ReadLine();

                string animal;
                Console.Write("Please enter a Animal: \n");
                animal = Console.ReadLine();

                string food;
                Console.Write("Please enter a food: \n");
                food = Console.ReadLine();

                string verb;
                Console.Write("Please enter a verb: \n");
                verb = Console.ReadLine();

                string first_noun;
                Console.Write("Please enter a noun: \n");
                first_noun = Console.ReadLine();

                string fruit;
                Console.Write("Please enter a fruit: \n");
                fruit = Console.ReadLine();

                string third_adjective;
                Console.Write("Please enter an adjective: \n");
                third_adjective = Console.ReadLine();

                string name2;
                Console.Write("Please enter a name: \n");
                name2 = Console.ReadLine();

                string country;
                Console.Write("Please enter a country: \n");
                country = Console.ReadLine();

                string name3;
                Console.Write("Please enter another name: \n");
                name3 = Console.ReadLine();

                string dessert;
                Console.Write("Please enter a dessert: \n");
                dessert = Console.ReadLine();

                string name4;
                Console.Write("Please enter another name: \n");
                name4 = Console.ReadLine();

                string year;
                Console.Write("Please enter a year: \n");
                year = Console.ReadLine();

                string second_noun;
                Console.Write("Please enter another noun: \n");
                second_noun = Console.ReadLine();

                // The template for the story:

                string story = $"This morning {name} woke up feeling {first_noun}. 'It is going to be a {first_noun}day!' Outside, a bunch of {adj1}s were protesting to keep {adj2} in stores. They began to {animal} to the rhythm of the {food}, which made all the {verb}s very {first_noun}. Concerned, {fruit} texted {third_adjective}, who flew {name2} to {country} and dropped {name3} in a puddle of frozen {dessert}. {name4} woke up in the year {year}, in a world where {second_noun}s ruled the world.";


                // Print the story:
                Console.WriteLine(story);
        }
    }
}
