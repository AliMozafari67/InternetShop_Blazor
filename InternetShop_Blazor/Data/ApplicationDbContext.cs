using InternetShop_Blazor.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternetShop_Blazor.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUsers, AppRols, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Ta_Category { get; set; }
        public DbSet<Products> Ta_Products { get; set; } 
    }
        
}