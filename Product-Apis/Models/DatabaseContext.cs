using Microsoft.EntityFrameworkCore;

namespace Product_Apis.Models
{
    public class DatabaseContext : DbContext
    {
		//Note : For code first migration follow below tutorial & commands
		// https://medium.com/c-sharp-programming/tutorial-code-first-approach-in-asp-net-core-mvc-with-ef-5baf5af696e9

		// Before running migration command you need to install Nuget package : Microsoft.EntityFrameworkCore.Tools 
		// the version of above nuget should be same as Microsoft.EntityFrameworkCore which is already istalled. 

		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
