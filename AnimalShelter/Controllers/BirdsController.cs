using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BirdsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public BirdsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Bird>> Get()
    {
        return _db.Birds.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Bird> Get(int id)
    {
        return _db.Birds.FirstOeDefault(tweety => tweety.BirdId == id);
    }

    [HttpPost]
    public void Post([FromBody] Bird bird)
  }
}
