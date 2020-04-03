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
        return _db.Birds.FirstOrDefault(tweety => tweety.BirdId == id);
    }

    [HttpPost]
    public void Post([FromBody] Bird bird)
    {
      _db.Birds.Add(bird);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Bird bird)
    {
      _db.Entry(bird).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Bird leftNest = _db.Birds.FirstOrDefault(tweety => tweety.BirdId == id);
      _db.Birds.Remove(leftNest);
      _db.SaveChanges();
    }
  }
}
