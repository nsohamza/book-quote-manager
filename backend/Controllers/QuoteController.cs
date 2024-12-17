using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookQuotesAPI.Data;
using BookQuotesAPI.Models;
using BookQuotesAPI.Models.Dtos;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;


namespace BookQuotesAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public QuotesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Quotes
        [HttpGet]
        public async Task<ActionResult<List<Quote>>> GetQuotes()
        {
            return await _context.Quotes.ToListAsync();
        }


        // GET: api/Quotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> GetQuote(int id)
        {
            var quote = await _context.Quotes.FirstOrDefaultAsync(q => q.QuoteId == id);

            if (quote == null)
            {
                return NotFound();
            }

            return quote;
        }
        

        // POST: api/Quotes
       [HttpPost]
      public async Task<ActionResult<Quote>> PostQuote(QuoteDtO quoteDto)
       {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            // Map the QuoteDto to a Quote entity
            var quote = new Quote
            {
                Text = quoteDto.Text,
                //UserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) // Assuming you're using JWT and have a user authenticated
                //UserId = quoteDto.UserId,
                 UserId = userId,

            };

            // Add the Quote entity to the context
              _context.Quotes.Add(quote);
              await _context.SaveChangesAsync();

             // Return the created Quote
              return CreatedAtAction(nameof(GetQuote), new { id = quote.QuoteId}, quote);
        }


        // PUT: api/Quotes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuote(int id, QuoteDtO quoteDto)
        {
            if (id != quoteDto.QuoteId)
            {
                return BadRequest();
            }

             // Retrieve the existing quote from the database
         var existingQuote = await _context.Quotes.FindAsync(id);

             if (existingQuote == null)
           {
                  return NotFound();
            }
            // Update the properties of the existing quote
          existingQuote.Text = quoteDto.Text;
          existingQuote.UserId = quoteDto.UserId;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(id))
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

        // DELETE: api/Quotes/5
    
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuote(int id)
        {
            var quote = await _context.Quotes.FindAsync(id);
            if (quote == null)
            {
                return NotFound();
            }

            _context.Quotes.Remove(quote);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuoteExists(int id)
        {
            return _context.Quotes.Any(e => e.QuoteId== id);
        }
    }
}
