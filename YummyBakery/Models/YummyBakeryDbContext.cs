using Microsoft.EntityFrameworkCore;

namespace YummyBakery.Models
{
    public class YummyBakeryDbContext : DbContext
    {
        public YummyBakeryDbContext(DbContextOptions<YummyBakeryDbContext> options) : base(options) 
        { 
 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }    
    }
}
