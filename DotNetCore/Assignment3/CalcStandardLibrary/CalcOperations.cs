using System;
using System.Collections.Generic;
using System.Text;

namespace CalcStandardLibrary
{
    public class CalcOperations
    {
        public int Add(int num1, int num2)
        {
            int Addition = num1 + num2;
            return Addition;
        }

        public int Substract(int num1, int num2)
        {
            int Substract = num1 - num2;
            return Substract;
        }

        public int Multiply(int num1, int num2)
        {
            int Multiply = num1 * num2;
            return Multiply;
        }

        public int Divide(int num1, int num2)
        {
            int Divide = num1 / num2;
            return Divide;
        }
    }
}
