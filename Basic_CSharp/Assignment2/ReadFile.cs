using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Program to Read a Text File. 

namespace PracticeCSharp.Assignment2
{
    internal class ReadFile
    {
        public void readfile()
        {
            String file = @"C:\Users\smita.pradhan\source\repos\Smita_Repo\PracticeCSharp\Assignment2\file.txt";
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}
