using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("{firstName}/{lastName}")]
        public String SayHello(string firstName, string lastName)
        {

            Student st = new Student
            {
                Name = firstName,
                Surname = lastName
            };
            return "Hello " + st;
        }
    }
}
