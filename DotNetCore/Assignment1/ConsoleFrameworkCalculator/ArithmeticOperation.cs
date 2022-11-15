using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFrameworkCalculator
{
    internal class ArithmeticOperation
    {
        public static void addition(int num1,int num2)
        {
            int Addition=num1+ num2;
            Console.WriteLine("Addition: " + Addition);
        }
        public static void substraction(int num1, int num2)
        {
            int Substraction = num1 - num2;
            Console.WriteLine("Substraction: " + Substraction);
        }
        public static void multiplication(int num1, int num2)
        {
            int Multiplication = num1 * num2;
            Console.WriteLine("Multiplication: " + Multiplication);
        }
        public static void division(int num1, int num2)
        {
            int Division = num1 / num2;
            Console.WriteLine("Division: " + Division);
        }
    }
}
