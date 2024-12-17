using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookQuotesAPI.Models.Dtos
{
public class BookDto
{
    public int BookId { get; set; }            // Primary Key
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime PublicationDate { get; set; }
}
}