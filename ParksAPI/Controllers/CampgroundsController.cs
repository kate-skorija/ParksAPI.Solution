using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ParksAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CampgroundsController : ControllerBase
  {
    private ParksAPIContext _db;
    public CampgroundsController(ParksAPIContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Campground>> Get(string state)
    {
      var query = _db.Campgrounds.AsQueryable();
      if (state != null)
        {
          query = query.Where(entry => entry.State == state);
        }
      return query.ToList();
    }


    [HttpPost]
    public void Post([FromBody] Campground campground)
    {
      _db.Campgrounds.Add(campground);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Campground> Get(int id)
    {
      return _db.Campgrounds.FirstOrDefault(entry => entry.CampgroundId == id);
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Campground campground)
    {
      campground.CampgroundId = id;
      _db.Entry(campground).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var campToDelete = _db.Campgrounds.FirstOrDefault(entry => entry.CampgroundId == id);
      _db.Campgrounds.Remove(campToDelete);
      _db.SaveChanges();
    }
  }
}
