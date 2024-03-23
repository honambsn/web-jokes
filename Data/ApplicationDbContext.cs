using Microsoft.EntityFrameworkCore;
using jokes.Models;

namespace jokes.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<jokes.Models.Joke> Joke { get; set; } = default!;

        
    }
}
