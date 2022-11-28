namespace CalculatorStandardLibrary
{
    public class Calculator
    {

        public int Add(int num1,int num2)
        {
            int result=num1+ num2;
            return result;
        }
        public int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

    }
}