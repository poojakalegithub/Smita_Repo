using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.PracticeCode
{
    internal class forloop
    {
        int table = 5;
        public int printTable()
        {
            Console.WriteLine("Table of Number: " + table);
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(table*i);
            }
            return 0;
        }
    }
}
