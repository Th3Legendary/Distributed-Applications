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
    public class GPUsController : ControllerBase
    {
        private readonly PCDbContext _context;

        public GPUsController(PCDbContext context)
        {
            _context = context;
        }

        // GET: api/GPUs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GPU>>> GetGPUs()
        {
            return await _context.GPUs.ToListAsync();
        }

        // GET: api/GPUs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GPU>> GetGPU(int id)
        {
            var gPU = await _context.GPUs.FindAsync(id);

            if (gPU == null)
            {
                return NotFound();
            }

            return gPU;
        }

        // PUT: api/GPUs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGPU(int id, GPU gPU)
        {
            if (id != gPU.GPUId)
            {
                return BadRequest();
            }

            _context.Entry(gPU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GPUExists(id))
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

        // POST: api/GPUs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GPU>> PostGPU(GPU gPU)
        {
            _context.GPUs.Add(gPU);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGPU", new { id = gPU.GPUId }, gPU);
        }

        // DELETE: api/GPUs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GPU>> DeleteGPU(int id)
        {
            var gPU = await _context.GPUs.FindAsync(id);
            if (gPU == null)
            {
                return NotFound();
            }

            _context.GPUs.Remove(gPU);
            await _context.SaveChangesAsync();

            return gPU;
        }

        private bool GPUExists(int id)
        {
            return _context.GPUs.Any(e => e.GPUId == id);
        }
    }
}
