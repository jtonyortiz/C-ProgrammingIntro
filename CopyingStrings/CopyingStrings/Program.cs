using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Copying & Swapping Strings";
            string car1 = "Gibili";
            string car2 = "GranTurismo";
            Console.WriteLine("Original:");
            Console.WriteLine("\tCar 1: " + car1 + "\t\tCar 2: " + car2);

            //Copy the value of the second string variable to the first string 
            //variable, then dispaly the modified values:
            car1 = String.Copy(car2);
            Console.WriteLine("\nCopied:");
            Console.WriteLine("\tCar 1: " + car1 + "\tCar 2: " + car2);

            //Initialize an integer vairable with the length of the first
            //string variable, then create a char. array of that length:
            int num = car1.Length;
            char[] model = new char[num];

            //Copy the first str. variable into the array, then 
            //display a space separated list of the element contents:

            car1.CopyTo(0, model, 0, num);
            Console.WriteLine("\nCharacter Array: ");
            foreach(char c in model)
            {
                Console.Write(c + " ");
            }

            //Remove the end of the first string variable, 
            //starting from the 5th element, and display the
            //modified value:
            car1 = car1.Remove(4);
            Console.WriteLine("\n\nRemoved...\tCar 1: " + car1);

            //Insert 2 strings into the 1st string variable,
            //at its beginning and end, then display the modified
            //value:
            car1 = car1.Insert(0, "Maserati ");
            car1 = car1.Insert(13, "Cabrio");
            Console.WriteLine("\nInserted...\tCar 1: " + car1);

            //Finally, replace the substring within the first string 
            //variable, and once more display the modified value:
            car1 = car1.Replace("GranCabrio", "Quattroporte");
            Console.WriteLine("\nReplaced..\tCar 1: " + car1);
            Console.ReadKey();


        }
    }
}
