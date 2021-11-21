using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParksApi.Models;

namespace NationalParksApi.Controllers
{
  [Route("api/nationalparks/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly NationalParksApiContext _db;
    public ParksController(NationalParksApiContext db)
    {
      _db = db;
    }
     [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string region, string state, string description)
    {
      var query = _db.Parks.AsQueryable();
       if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }
      if (region != null)
      {
        query = query.Where(e => e.Region == region);
      }
       if (state != null)
      {
        query = query.Where(e => e.State == state);
      }
      if (description != null)
      {
        query = query.Where(e => e.Description.Contains(description));
      }
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<Park>>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var Park = await _db.Parks.FindAsync(id);
      if (Park == null)
      {
        return NotFound();
      }
      return Park;
    }

        [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();
      return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }
      _db.Entry(park).State = EntityState.Modified;
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(p => p.ParkId == id);
    }
  }
}
