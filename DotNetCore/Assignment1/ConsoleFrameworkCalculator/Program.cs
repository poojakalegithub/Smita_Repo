using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFrameworkCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 50;
            int value2 = 5;
            ArithmeticOperation.addition(value1, value2);
            ArithmeticOperation.substraction(value1, value2);
            ArithmeticOperation.multiplication(value1, value2);
            ArithmeticOperation.division(value1, value2);


        }
    }
}
