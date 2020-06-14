using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraAPI.Interfaces;

namespace MiPrimeraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesProvider coursesProvider;

        public CoursesController(ICoursesProvider coursesProvider)
        {
            this.coursesProvider = coursesProvider;
        }

        //[HttpGet]
        [HttpGet("{number}")]
        public IActionResult Get(int number) // ActionResult<int>
        {
            if(number < 100)
            {
                return Ok(number);
            }
            return NotFound(number);
        }
    }
}
