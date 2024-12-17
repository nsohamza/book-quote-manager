using Microsoft.EntityFrameworkCore;
using BookQuotesAPI.Data;
using BookQuotesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BookQuotesAPI.Models.Dtos;

namespace BookQuotesAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // POST: api/Books
     
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(BookDto bookDto)
        {
         var book = new Book
        {
             Title = bookDto.Title,
              Author = bookDto.Author,
              PublicationDate = bookDto.PublicationDate
        };

         _context.Books.Add(book);
          await _context.SaveChangesAsync();

         return CreatedAtAction(nameof(GetBook), new { id = book.BookId}, book);
    }   

[HttpPut("{id}")]
public async Task<IActionResult> UpdateBook(int id, BookDto bookDto)
{
    var book = await _context.Books.FindAsync(id);
    if (book == null)
    {
        return NotFound();
    }

    book.Title = bookDto.Title ?? book.Title;
    book.Author = bookDto.Author ?? book.Author;
    book.PublicationDate = bookDto.PublicationDate;

    await _context.SaveChangesAsync();

    return NoContent();
}
   
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
    }
}






