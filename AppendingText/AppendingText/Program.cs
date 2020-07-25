using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Allows for use of File IO:

namespace AppendingText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Appending Text To Files";
            //Path to file:
            string path = "C:\\Users\\james\\OneDrive\\Desktop\\oscar.txt";
            string[] poem = new string[]
            {
                "\tIn Debtors' Yard the stones are hard",
                "\tAnd the dripping wall is high"
            };
            string attrib = "\r\n\tThe Ballad Of Reading Gaol ";
            attrib += "(Oscar Wilde 1898)";

            //Check if a file alwready exists:
            if(File.Exists(path))
            {
                //Attempt to append text if file alwready exists:
                File.AppendAllText(path, attrib);
                Console.WriteLine("Appended To File: " + path);
            }
            else
            {
                try
                {
                    File.WriteAllLines(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            Console.ReadKey();


        }
    }
}
