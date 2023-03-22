using Microsoft.EntityFrameworkCore;

namespace WebSurvey.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public DbSet<Survey> surveys { get; set; }
        public DbSet<Answers> answers { get; set; }
        
    }
}
