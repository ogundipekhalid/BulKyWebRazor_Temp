using BulKyWebRezor_Temp.Model;
using Microsoft.EntityFrameworkCore;

namespace BulKyWebRezor_Temp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    
       public DbSet<Category> Categories {get; set;}
          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
            (
                    new Category { Id = 1, Name ="Triller" , DisplayOrder = 1 },
                    new Category { Id = 2, Name ="Wifi" ,  DisplayOrder = 2 },
                    new Category { Id = 3, Name ="Naughty" , DisplayOrder = 3 },
                    new Category { Id = 4, Name ="Bounce" , DisplayOrder = 3 }
            ); 
        }
}
