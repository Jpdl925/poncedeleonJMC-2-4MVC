using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace poncedeleonJMC_2_4MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class compareController : ControllerBase
    {
        [HttpGet]
        public string compare(int a = 1, int b = 2)
        {
            if (a > b)
            {
                return $"First number {a} is greater than second number {b}\nSecond number {b} is less than first number {a}";
            }
            else if (a < b)
            {
                return $"First number {a} is less than second number {b}\nSecond number {b} is greater than first number {a}";
            }
            else
            {
                return $"First number {a} and second number {b} are EQUAL";
            }
        }
    }
}