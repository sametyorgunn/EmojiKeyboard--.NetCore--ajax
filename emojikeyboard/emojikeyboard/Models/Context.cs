using Microsoft.EntityFrameworkCore;

namespace emojikeyboard.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=emoji;username=root;password=sonel.1234;port=3306");
        }
        public DbSet<Emoji>emojis { get; set; }
    }
}
