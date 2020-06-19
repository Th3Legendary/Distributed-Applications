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
    public class BuildListsController : ControllerBase
    {
        private readonly PCDbContext _context;

        public BuildListsController(PCDbContext context)
        {
            _context = context;
        }

        // GET: api/BuildLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildList>>> GetBuildLists()
        {
            return await _context.BuildLists.ToListAsync();
        }

        // GET: api/BuildLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BuildList>> GetBuildList(int id)
        {
            var buildList = await _context.BuildLists.FindAsync(id);

            if (buildList == null)
            {
                return NotFound();
            }

            return buildList;
        }

        // PUT: api/BuildLists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuildList(int id, BuildList buildList)
        {
            if (id != buildList.BuildId)
            {
                return BadRequest();
            }

            _context.Entry(buildList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildListExists(id))
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

        // POST: api/BuildLists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BuildList>> PostBuildList(BuildList buildList)
        {
            _context.BuildLists.Add(buildList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuildList", new { id = buildList.BuildId }, buildList);
        }

        // DELETE: api/BuildLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BuildList>> DeleteBuildList(int id)
        {
            var buildList = await _context.BuildLists.FindAsync(id);
            if (buildList == null)
            {
                return NotFound();
            }

            _context.BuildLists.Remove(buildList);
            await _context.SaveChangesAsync();

            return buildList;
        }

        private bool BuildListExists(int id)
        {
            return _context.BuildLists.Any(e => e.BuildId == id);
        }
    }
}
