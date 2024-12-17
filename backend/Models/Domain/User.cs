using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookQuotesAPI.Controllers;

namespace BookQuotesAPI.Models
{
  public class User
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }            // Primary Key
    public string? Username { get; set; }   // Username for login
    public string? Password { get; set; }   // Password for login

    public List<Quote> Quotes { get; set; } = new();       // Navigation property for one-to-many relationship with Quote


}
}
