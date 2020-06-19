using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC.Data;
using PC.Models.Entities;

namespace PC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PSUsController : ControllerBase
    {
        private readonly PCDbContext _context;

        public PSUsController(PCDbContext context)
        {
            _context = context;
        }

        // GET: api/PSUs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PSU>>> GetPSUs()
        {
            return await _context.PSUs.ToListAsync();
        }

        // GET: api/PSUs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PSU>> GetPSU(int id)
        {
            var pSU = await _context.PSUs.FindAsync(id);

            if (pSU == null)
            {
                return NotFound();
            }

            return pSU;
        }

        // PUT: api/PSUs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPSU(int id, PSU pSU)
        {
            if (id != pSU.PSUId)
            {
                return BadRequest();
            }

            _context.Entry(pSU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PSUExists(id))
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

        // POST: api/PSUs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PSU>> PostPSU(PSU pSU)
        {
            _context.PSUs.Add(pSU);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPSU", new { id = pSU.PSUId }, pSU);
        }

        // DELETE: api/PSUs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PSU>> DeletePSU(int id)
        {
            var pSU = await _context.PSUs.FindAsync(id);
            if (pSU == null)
            {
                return NotFound();
            }

            _context.PSUs.Remove(pSU);
            await _context.SaveChangesAsync();

            return pSU;
        }

        private bool PSUExists(int id)
        {
            return _context.PSUs.Any(e => e.PSUId == id);
        }
    }
}
