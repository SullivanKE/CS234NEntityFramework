using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CS234NEntityFramework.Models;

namespace CS234NEntityFrameworkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppConfigsController : ControllerBase
    {
        private readonly BitsContext _context;

        public AppConfigsController(BitsContext context)
        {
            _context = context;
        }

        // GET: api/AppConfigs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppConfig>>> GetAppConfigs()
        {
            return await _context.AppConfigs.ToListAsync();
        }

        // GET: api/AppConfigs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppConfig>> GetAppConfig(int id)
        {
            var appConfig = await _context.AppConfigs.FindAsync(id);

            if (appConfig == null)
            {
                return NotFound();
            }

            return appConfig;
        }

        // PUT: api/AppConfigs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppConfig(int id, AppConfig appConfig)
        {
            if (id != appConfig.BreweryId)
            {
                return BadRequest();
            }

            _context.Entry(appConfig).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppConfigExists(id))
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

        // POST: api/AppConfigs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppConfig>> PostAppConfig(AppConfig appConfig)
        {
            _context.AppConfigs.Add(appConfig);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AppConfigExists(appConfig.BreweryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAppConfig", new { id = appConfig.BreweryId }, appConfig);
        }

        // DELETE: api/AppConfigs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppConfig(int id)
        {
            var appConfig = await _context.AppConfigs.FindAsync(id);
            if (appConfig == null)
            {
                return NotFound();
            }

            _context.AppConfigs.Remove(appConfig);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppConfigExists(int id)
        {
            return _context.AppConfigs.Any(e => e.BreweryId == id);
        }
    }
}
