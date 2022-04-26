using Microsoft.EntityFrameworkCore;

namespace C_Sharp_Boiler.Models
{
    public class MyContext : DbContext
    {
            public MyContext(DbContextOptions options) : base(options) {}

            // ADD DB SETS HERE
            public DbSet<User> Users {get; set;}
    }
}