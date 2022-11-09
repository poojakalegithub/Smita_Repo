using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to demonstrate User Defined Exception
namespace PracticeCSharp.Assignment2
{
    public class CustomDivideByZero : Exception
    {
        public CustomDivideByZero()
        {
            Console.WriteLine("Error Occured since demnominator is zero...!");
        }

    }

    internal class UserDefinedException : CustomDivideByZero
    {
        
        public void divide()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result;
            if (num2 == 0)
            {
                throw new CustomDivideByZero();
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }

        }

    }
}
