using Microsoft.EntityFrameworkCore;

namespace CountryAPI.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext(DbContextOptions<CountryContext>options)
            :base (options)
        {

        }
        public DbSet<CountryItems> CountryItems { get; set; } = null!;
    }
}
