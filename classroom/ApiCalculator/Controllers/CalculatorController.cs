using Microsoft.AspNetCore.Mvc;

namespace ApiCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("Addition")]
        public IActionResult Addition(decimal firstNum, decimal secondNum)
        {
            var result = firstNum + secondNum;
            return Ok(result);
        }

        [HttpGet]
        [Route("Subtraction")]
        public IActionResult Subtraction(decimal firstNum, decimal secondNum)
        {
            var result = firstNum - secondNum;
            return Ok(result);
        }

        [HttpGet]
        [Route("Multiplication")]
        public IActionResult Multiplication(decimal firstNum, decimal secondNum)
        {
            var result = firstNum * secondNum;
            return Ok(result);
        }

        [HttpGet]
        [Route("Division")]
        public IActionResult Division(decimal firstNum, decimal secondNum)
        {
            if (secondNum == 0)
            {
                throw new ArgumentException("can't divide by zero.");
            }
            var result = firstNum / secondNum;
            return Ok(result);
        }
    }
}
