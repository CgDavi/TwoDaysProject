using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TwoDaysProject.Entities.Identity;
using TwoDaysProject.Entities.Management;

namespace TwoDaysProject.Database
{
    public class CustomDbContext : IdentityDbContext<CustomUser, CustomRole, string>
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CustomDbInitializer(modelBuilder).Seed();
        }
        public DbSet<SitePage> SitePages { get; set; }
        public DbSet<GeneralConfig> GeneralConfigs { get; set; }
    }
}
