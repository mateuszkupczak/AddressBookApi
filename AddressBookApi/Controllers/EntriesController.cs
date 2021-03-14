using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AddressBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntriesController : ControllerBase
    {
        private readonly EntryContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<EntriesController> _logger;

        public EntriesController(EntryContext context, IMapper mapper, ILogger<EntriesController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        private ActionResult HandleException(Exception ex)
        {
            _logger.LogError($"An exception {ex.GetType()} has been thrown: {ex.Message}");
            return StatusCode(500);
        }

        [HttpPost]
        public async Task<ActionResult<Entry>> PostEntry(EntryDto entryDto)
        {
            try
            {
                Entry entry = _mapper.Map<Entry>(entryDto);
                _context.Entries.Add(entry);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetLastEntry", new { id = entry.Id }, entry);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public async Task<ActionResult<Entry>> GetLastEntry()
        {
            try
            {
                var entry = await _context.Entries
                    .OrderByDescending(el => el.CreationDate)
                    .FirstOrDefaultAsync();

                if (entry == null)
                {
                    return NoContent();
                }

                return entry;
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet("{town}")]
        public async Task<ActionResult<IEnumerable<Entry>>> GetEntriesForTown(string town)
        {
            try
            {
                var entries = await _context.Entries
                    .Where(el => el.Town != null && el.Town.ToUpper() == town.ToUpper())
                    .OrderByDescending(el => el.CreationDate)
                    .ToListAsync();

                if (entries == null || !entries.Any())
                {
                    return NoContent();
                }

                return entries;
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
    }
}
