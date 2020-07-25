using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Writing To TextFiles"
            string path = "C:\\Users\\james\\OneDrive\\Desktop\\poems.txt";
            string poem = "\r\n\tI never saw a man who looked";
            poem += "\r\n\tWith such a wistful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            if(File.Exists(path))
            {
                Console.WriteLine("File Already Exists:" + path);
            }
            else
            {
                //Insert Stmts. that attempt to write a text file 
                //and confirm success, or advise a failure:
                try
                {
                    File.WriteAllText(path, poem);
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
