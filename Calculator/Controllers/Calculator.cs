using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet]
    public string Get(double val1, char operation, double val2)
    {
        switch(operation)
        {
            case '+':
                return (val1 + val2).ToString();
            case '-':
                return (val1 - val2).ToString();
            case '*':
                return (val1 * val2).ToString();
            case '/':
                return (val1 / val2).ToString();
            default:
                return "Please enter a valid operator (+, -, * or /)";

        }        
    }
}

