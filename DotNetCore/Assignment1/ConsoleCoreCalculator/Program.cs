using System;

namespace ConsoleCoreCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 100;
            int value2 = 50;
            ArithmeticOperation.addition(value1, value2);
            ArithmeticOperation.substraction(value1, value2);
            ArithmeticOperation.multiplication(value1, value2);
            ArithmeticOperation.division(value1, value2);
        }
    }
}
