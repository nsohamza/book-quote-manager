using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookQuotesAPI.Models
{
     public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BookId { get; set; }            // Primary Key
    public string? Title { get; set; }       // Title of the book
    public string? Author { get; set; }      // Author of the book
    public DateTime PublicationDate { get; set; } // Publication date of the book

    }
}
