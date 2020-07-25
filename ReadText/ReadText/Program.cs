using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Read Text From File";

            string path = "C:\\Users\\james\\OneDrive\\Desktop\\word.txt";

            //Check to see if the file alwready exists:
            if(File.Exists(path))
            {
                //
                try
                {
                    //Insert stmts. to assign the txt file contents 
                    //to a var. and display value:
                    string text = File.ReadAllText(path);
                    Console.WriteLine("File Read: " + path + "\n");
                    Console.WriteLine(text + "\n");

                    //Assign txt file contents to an array variable
                    //and display each element with a counter:
                    string[] lines = File.ReadAllLines(path);
                    int num = 1;
                    foreach(string line in lines)
                    {
                        Console.WriteLine(num + " : " + line);
                        num++;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                Console.WriteLine("File Not Found: " + path);
            }

            Console.ReadKey();
        }//end MAIN
    }
}
