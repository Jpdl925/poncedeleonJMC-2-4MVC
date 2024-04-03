using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace poncedeleonJMC_2_4MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class mathController : ControllerBase
    {
        [HttpGet]
        public string doMath(int a = 1, int b = 2)
        {
            return $"{a} + {b} = {a + b}";
        }

    }

}