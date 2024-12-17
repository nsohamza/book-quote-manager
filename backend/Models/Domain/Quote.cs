
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookQuotesAPI.Models
{
    public class Quote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuoteId { get; set; }
        public string? Text { get; set; }
        public int UserId { get; set; }  // Foreign Key
        public User? User { get; set; }  // Navigation property
    }
}

