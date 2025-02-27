using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "26b41c32-a69e-49ba-b03e-dc1cdb60e27f", Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole { Id = "a52a6da3-c49d-4785-a41f-4a55349ff04d", Name = "Admin", NormalizedName = "ADMIN" }
            );
        }
    }
}