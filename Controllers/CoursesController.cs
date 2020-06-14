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

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
      var results = await coursesProvider.GetAllAsync();
      if (results != null)
      {
        return Ok(results);
      }

      return NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
      var result = await coursesProvider.GetAsync(id);
      if (result != null)
      {

      }
    }
  }
}
