using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace poncedeleonJMC_2_4MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class wakeUpController : ControllerBase
    {
        [HttpGet]
        public string wakeUp(string name = "Nobody", string time = "some time", string amPm = "Pm")
        {
            return $"Hello {name}, you woke up at {time}{amPm}. Congrats!";
        }
    }
}