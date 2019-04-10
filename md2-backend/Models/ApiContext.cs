using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace md2_backend.Models
{
    public class ApiContext :IdentityDbContext<IdentityUser> //DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new { Id ="1" , Name = "Admin", NormalizedName = "ADMIN" },
                new { Id ="2" , Name = "Client", NormalizedName = "Client" },
                new { Id ="3" , Name = "Moderator", NormalizedName = "Moderator" }
                );
        }
        public DbSet<Property> Properties { get; set; }
    }
}