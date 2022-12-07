namespace WebApplication_Calculations.services
{
    public interface ICalculations
    {
        double Add(double operand1,double operand2);

        double Substract(double operand1, double operand2);

        double Multiply(double operand1, double operand2);

        double Divide(double operand1, double operand2);

    }
}
