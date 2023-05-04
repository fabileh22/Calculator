using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

//FL 04.05.23

//Controller to execute the GET-request
[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet]
    public string Get(double val1, char operation, double val2)
    {
        //Depending on which operator is selected, a result is created
        //The Operators can only be +, -, * and / to generate a result
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

