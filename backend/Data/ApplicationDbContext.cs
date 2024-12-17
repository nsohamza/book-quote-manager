using Microsoft.EntityFrameworkCore;
using BookQuotesAPI.Models;

namespace BookQuotesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public required DbSet<Book> Books { get; set; }
        public required DbSet<User> Users { get; set; }
        public required DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Here is the one-to-many relationship between User and Quote. 
            modelBuilder.Entity<Quote>()
                .HasOne(q => q.User)
                .WithMany(u => u.Quotes)
                .HasForeignKey(q => q.UserId);
        
        }
    }
}


