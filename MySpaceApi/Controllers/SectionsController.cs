using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySpaceApi.Data;
using MySpaceApi.Model;

namespace MySpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionsController : ControllerBase
    {
        private readonly MySpaceApiDbContext _context;

        public SectionsController(MySpaceApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Sections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Section>>> GetSection(String sort)
        {
            IQueryable<Section> sections = _context.Section;
            if (null == sections)
            {
                return NotFound();
            }
            switch (sort)
            {
                case "desc":
                    sections = _context.Section.OrderByDescending(q => q.CreatedAt);
                    break;
                case "asc":
                    sections = _context.Section.OrderBy(q => q.CreatedAt);
                    break;
                default:
                    sections = _context.Section;
                    break;
            }
            return Ok(sections);
            return await _context.Section.ToListAsync();
        }

        // GET: api/Sections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Section>> GetSection(int id)
        {
            var section = await _context.Section.FindAsync(id);

            if (section == null)
            {
                return NotFound();
            }

            return section;
        }

        // PUT: api/Sections/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSection(int id, Section section)
        {
            if (id != section.SectionID)
            {
                return BadRequest();
            }

            _context.Entry(section).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(id))
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

        // POST: api/Sections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Section>> PostSection(Section section)
        {
            _context.Section.Add(section);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSection", new { id = section.SectionID }, section);
        }

        // DELETE: api/Sections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSection(int id)
        {
            var section = await _context.Section.FindAsync(id);
            if (section == null)
            {
                return NotFound();
            }

            _context.Section.Remove(section);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SectionExists(int id)
        {
            return _context.Section.Any(e => e.SectionID == id);
        }
    }
}
