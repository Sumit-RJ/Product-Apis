using Microsoft.EntityFrameworkCore;

namespace Product_Apis.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
