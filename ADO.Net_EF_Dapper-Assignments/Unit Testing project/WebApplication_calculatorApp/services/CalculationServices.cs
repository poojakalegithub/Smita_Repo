namespace WebApplication_Calculations.services
{
    public class CalculationServices : ICalculations
    {
        public double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public double Divide(double operand1, double operand2)
        {
            return operand1 / operand2;
        }

        public double Multiply(double operand1, double operand2)
        {
            return operand1 * operand2; 
        }

        public double Substract(double operand1, double operand2)
        {
            return operand1 - operand2; 
        }
    }
}
