﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImputAndOutputManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Input and Output Manipulation";

            string path = "C:\\Users\\james\\OneDrive\\Desktop\\TopFive.csv";

            try
            {
                //
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        //TODO: Steps 6 - 7 
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper();
                        if (line.IndexOf("Sia") != -1) line += " ft.Sean Paul";

                        string[] sub = line.Split(',');
                        line = String.Format("{0, -30}{1,-20}", sub[1], sub[2]);
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            { 
                Console.WriteLine(error.Message);
            }

            Console.ReadKey();
        }
    }
}
