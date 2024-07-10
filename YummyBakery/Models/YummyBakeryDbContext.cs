using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YummyBakery.Models
{
    public class YummyBakeryDbContext : IdentityDbContext
    {
        public YummyBakeryDbContext(DbContextOptions<YummyBakeryDbContext> options) : base(options) 
        { 
 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }    
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
