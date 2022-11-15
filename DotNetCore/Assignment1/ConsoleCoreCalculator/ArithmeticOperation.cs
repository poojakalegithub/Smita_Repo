using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCoreCalculator
{
    internal class ArithmeticOperation
    {
        public static void addition(int num1, int num2)
        {
            int addition = num1 + num2;
            Console.WriteLine("Addition: " + addition);
        }
        public static void substraction(int num1, int num2)
        {
            int substraction = num1 - num2;
            Console.WriteLine("Substraction: " + substraction);
        }
        public static void multiplication(int num1, int num2)
        {
            int multiplication = num1 * num2;
            Console.WriteLine("Multiplication: " + multiplication);
        }
        public static void division(int num1, int num2)
        {
            int division = num1 / num2;
            Console.WriteLine("Division: " + division);
        }
    }
}
