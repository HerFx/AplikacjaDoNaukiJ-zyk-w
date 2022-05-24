using Microsoft.EntityFrameworkCore;

namespace AplikacjaDoNaukiJęzyków.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Slowo> Slowa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slowo>().HasData(
                new Slowo 
                {
                    ID = 1,
                    PoziomSlowa = "podstawowy",
                    SlowoPol = "Witam",
                    SlowoAng = "Hello",
                    SlowoAra = "أهلا",
                    SlowoUkr = "привіт"
                }
                );
        }
    }
}
