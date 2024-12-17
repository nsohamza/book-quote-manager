using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BookQuotesAPI.Data;
using BookQuotesAPI.Models.Dtos;

namespace BookQuotesAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    // Ensure only authenticated users can access these endpoints

    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users/me/quotes
        [HttpGet("me/quotes")]
             public async Task<ActionResult<List<QuoteDtO>>> GetQuotes()
            {
             var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var quotes = await _context.Quotes.Where(q => q.UserId == userId).ToListAsync();

             // Map quotes to QuoteDto objects
             var quoteDtos = quotes.Select(q => new QuoteDtO
           {
                  Text = q.Text,      // Map Text from Quote to Text in QuoteDto
                  UserId = q.UserId,
           }).ToList();

              return Ok(quoteDtos);
}
        private bool QuoteExists(int id)
        {
            return _context.Quotes.Any(e => e.UserId == id);
        }
    }
}


