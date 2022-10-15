using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicCalculator;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : Controller
    {

        double result = 0;


        [HttpGet]
        public double Addition(double left, double right)
        {
            return BasicCalculator.CalculatorLogic.Addition(left, right); // if user want to add 2 numbers this api works
        }

        [HttpGet]
        public double Subtraction(double left, double right) // if user want to subtract 2 numbers this api works
        {
            return BasicCalculator.CalculatorLogic.Addition(left, right);
        }


        [HttpGet]
        public double Multiplication(double left, double right) // if user want to multiply 2 numbers this api works
        {
            return BasicCalculator.CalculatorLogic.Multiplication(left, right);
        }

        [HttpGet]
        public double Division(double left, double right) // if user want to divide 2 numbers this api works

    {
            double result = 0;

            try

            {

                result = BasicCalculator.CalculatorLogic.Division(left, right);

            }

            catch (DivideByZeroException)
            {
                Response.StatusCode = 400;  // This 400 will be going to display if second number is missing
            }


            return result;
        }
    }
}

