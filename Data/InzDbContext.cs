using Microsoft.EntityFrameworkCore;
using Praca_Inżynierska.Models.Domain;

namespace Praca_Inżynierska.Data
{
    public class InzDbContext : DbContext
    {
        public InzDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        

    }
}
