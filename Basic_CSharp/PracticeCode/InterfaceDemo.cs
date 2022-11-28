using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

// To Practice code for Interfaces
namespace PracticeCSharp.PracticeCode
{
    interface InterfaceDemo
    {
         void showDetails();
    }
    class Details : InterfaceDemo
    {
        public void showDetails()
        {
            Console.WriteLine("Implementing interface methods in child class");
        }
    }
    
}