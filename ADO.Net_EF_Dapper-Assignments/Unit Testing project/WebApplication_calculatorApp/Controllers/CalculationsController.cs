using Microsoft.AspNetCore.Mvc;
using WebApplication_Calculations.services;

namespace WebApplication_Calculations.Controllers
{
    [Route("api/calculation")]
    [ApiController]
    public class CalculationsController : Controller
    {
        private ICalculations _calculationServiceRepo = null;

        public CalculationsController(ICalculations calculationsServices)
        {
            _calculationServiceRepo = calculationsServices;
        }

        [HttpPost]
        [Route("Add")]

        public double Add(double operand1,double operand2)
        {
            return _calculationServiceRepo.Add(operand1,operand2);

        }

        [HttpPost]
        [Route("Divide")]

        public double Divide(double operand1, double operand2)
        {
            return _calculationServiceRepo.Divide(operand1, operand2);

        }


        [HttpPost]
        [Route("Multiply")]

        public double Multiply(double operand1, double operand2)
        {
            return _calculationServiceRepo.Multiply(operand1, operand2);

        }

        [HttpPost]
        [Route("Substract")]

        public double Substract(double operand1, double operand2)
        {
            return _calculationServiceRepo.Substract(operand1, operand2);

        }
    }
}
