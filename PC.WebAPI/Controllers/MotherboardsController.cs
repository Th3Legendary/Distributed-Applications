using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC.Data;
using PC.Models.Entities;

namespace PC.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MotherboardsController : ControllerBase
    {
        private readonly PCDbContext _context;

        public MotherboardsController(PCDbContext context)
        {
            _context = context;
        }

        // GET: api/Motherboards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motherboard>>> GetMotherbaords()
        {
            return await _context.Motherbaords.ToListAsync();
        }

        // GET: api/Motherboards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Motherboard>> GetMotherboard(int id)
        {
            var motherboard = await _context.Motherbaords.FindAsync(id);

            if (motherboard == null)
            {
                return NotFound();
            }

            return motherboard;
        }

        // PUT: api/Motherboards/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMotherboard(int id, Motherboard motherboard)
        {
            if (id != motherboard.MotherboardId)
            {
                return BadRequest();
            }

            _context.Entry(motherboard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotherboardExists(id))
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

        // POST: api/Motherboards
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Motherboard>> PostMotherboard(Motherboard motherboard)
        {
            _context.Motherbaords.Add(motherboard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMotherboard", new { id = motherboard.MotherboardId }, motherboard);
        }

        // DELETE: api/Motherboards/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Motherboard>> DeleteMotherboard(int id)
        {
            var motherboard = await _context.Motherbaords.FindAsync(id);
            if (motherboard == null)
            {
                return NotFound();
            }

            _context.Motherbaords.Remove(motherboard);
            await _context.SaveChangesAsync();

            return motherboard;
        }

        private bool MotherboardExists(int id)
        {
            return _context.Motherbaords.Any(e => e.MotherboardId == id);
        }
    }
}
