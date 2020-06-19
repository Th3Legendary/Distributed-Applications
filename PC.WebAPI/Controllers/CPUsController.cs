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
    public class CPUsController : ControllerBase
    {
        private readonly PCDbContext _context;

        public CPUsController(PCDbContext context)
        {
            _context = context;
        }

        // GET: api/CPUs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CPU>>> GetCPUs()
        {
            return await _context.CPUs.ToListAsync();
        }

        // GET: api/CPUs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CPU>> GetCPU(int id)
        {
            var cPU = await _context.CPUs.FindAsync(id);

            if (cPU == null)
            {
                return NotFound();
            }

            return cPU;
        }

        // PUT: api/CPUs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCPU(int id, CPU cPU)
        {
            if (id != cPU.CPUId)
            {
                return BadRequest();
            }

            _context.Entry(cPU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CPUExists(id))
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

        // POST: api/CPUs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CPU>> PostCPU(CPU cPU)
        {
            _context.CPUs.Add(cPU);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCPU", new { id = cPU.CPUId }, cPU);
        }

        // DELETE: api/CPUs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CPU>> DeleteCPU(int id)
        {
            var cPU = await _context.CPUs.FindAsync(id);
            if (cPU == null)
            {
                return NotFound();
            }

            _context.CPUs.Remove(cPU);
            await _context.SaveChangesAsync();

            return cPU;
        }

        private bool CPUExists(int id)
        {
            return _context.CPUs.Any(e => e.CPUId == id);
        }
    }
}
