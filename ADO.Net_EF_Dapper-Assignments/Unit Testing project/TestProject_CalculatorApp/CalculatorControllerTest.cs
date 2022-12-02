
using WebApplication_Calculations.services;

namespace TestProject_Calculator
{
   
    public class CalculatorControllerTest
    {
        private CalculationServices _test = null;

        public CalculatorControllerTest()
        {
            if(_test==null)
            {
                _test = new CalculationServices();
            }
        }

        [Fact]
        public void Add()
        {
            double operand1 = 10;
            double operand2 = 10;
            double expected = 20;
            var actual=_test.Add(operand1, operand2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Substract()
        {
            double operand1 = 10;
            double operand2 = 5;
            double expected = 5;
            var actual = _test.Substract(operand1, operand2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply()
        {
            double operand1 = 10;
            double operand2 = 10;
            double expected = 100;
            var actual = _test.Multiply(operand1, operand2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide()
        {
            double operand1 = 10;
            double operand2 = 5;
            double expected = 2;
            var actual = _test.Substract(operand1, operand2);
            Assert.Equal(expected, actual);
        }
    }
}
