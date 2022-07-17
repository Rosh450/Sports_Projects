using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsService.Models;

namespace SportsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        private readonly SportsDbContext _context;

        public SportsController(SportsDbContext context)
        {
            _context = context;
        }

        // GET: api/Sports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sports>>> Getsports()
        {
          if (_context.sports == null)
          {
              return NotFound();
          }
            return await _context.sports.ToListAsync();
        }

        // GET: api/Sports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sports>> GetSports(int id)
        {
          if (_context.sports == null)
          {
              return NotFound();
          }
            var sports = await _context.sports.FindAsync(id);

            if (sports == null)
            {
                return NotFound();
            }

            return sports;
        }

        // PUT: api/Sports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSports(int id, Sports sports)
        {
            if (id != sports.sportsid)
            {
                return BadRequest();
            }

            _context.Entry(sports).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SportsExists(id))
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

        // POST: api/Sports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sports>> PostSports(Sports sports)
        {
          if (_context.sports == null)
          {
              return Problem("Entity set 'SportsDbContext.sports'  is null.");
          }
            _context.sports.Add(sports);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSports", new { id = sports.sportsid }, sports);
        }

        // DELETE: api/Sports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSports(int id)
        {
            if (_context.sports == null)
            {
                return NotFound();
            }
            var sports = await _context.sports.FindAsync(id);
            if (sports == null)
            {
                return NotFound();
            }

            _context.sports.Remove(sports);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SportsExists(int id)
        {
            return (_context.sports?.Any(e => e.sportsid == id)).GetValueOrDefault();
        }
    }
}
