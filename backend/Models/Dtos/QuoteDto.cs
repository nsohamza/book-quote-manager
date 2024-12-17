using System.ComponentModel.DataAnnotations;
namespace BookQuotesAPI.Models.Dtos
{
     public class QuoteDtO
    {
        public int QuoteId { get; set; }
        public string Text { get; set; } = string.Empty;
        public int UserId { get; set; } // Include UserId to associate with the user

     }
}

