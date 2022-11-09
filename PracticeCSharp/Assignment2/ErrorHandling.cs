using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to Demonstrate Built in Exceptions
namespace PracticeCSharp.Assignment2
{
    internal class ErrorHandling
    {
       // NullReferenceException
        public void HandlingNullReferenceException()
        {
            try
            {
                String name = null;
                Console.WriteLine(name.Length);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("String is Null");
            }
        }

       // DivideByZeroException

        public void HandlingDivideByZeroException()
        {
           
            Console.WriteLine("Enter two numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result;

            //if number2 is zero, exception will be caught by catch block
            try
            {
                result = number1 / number2;
                Console.WriteLine("Result :"+result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can Not Divide By Zero");
            }
        }
    }
}


//Created User Defined Exception OR Custom Exception



