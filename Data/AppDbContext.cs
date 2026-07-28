using Microsoft.EntityFrameworkCore;
using TerceraAPIarte.Models;

namespace TerceraAPIarte.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Obra> Obras {get; set;}
    }


}