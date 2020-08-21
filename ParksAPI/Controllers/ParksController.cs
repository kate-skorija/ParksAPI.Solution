using Microsoft.AspNetCore.Mvc;
using ParksAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ParksAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksAPIContext _db;
    public ParksController(ParksAPIContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
  }
}
