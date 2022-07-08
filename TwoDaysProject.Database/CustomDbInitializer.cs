using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TwoDaysProject.Entities.Identity;
using TwoDaysProject.Entities.Management;

namespace TwoDaysProject.Database
{
    public class CustomDbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public CustomDbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<CustomRole>().HasData(
                   new CustomRole() { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "SuperAdministrator", NormalizedName = "SUPERADMINISTRATOR" },
                   new CustomRole() { Id = "3f09027e-bead-438c-a97a-d9d01f8eade2", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                   new CustomRole() { Id = "599f7d0f-c150-421f-9132-5f9e822711c8", Name = "Moderator", NormalizedName = "MODERATOR" }
            );
            var hasher = new PasswordHasher<CustomUser>();
            var adminEmail = "zisisnikos@outlook.com";
            var password = hasher.HashPassword(null, "Admin123!");
            modelBuilder.Entity<CustomUser>().HasData(
                   new CustomUser() { Id = "39db4566-a788-490e-b8a6-4fe9b829fcc2", FirstName = "Nikos", LastName = "Zisis", Email = adminEmail, EmailConfirmed = true, PasswordHash = password, UserName = adminEmail, NormalizedEmail = adminEmail.ToUpper(), NormalizedUserName = adminEmail.ToUpper() }
                   );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                   new IdentityUserRole<string>
                   {
                       RoleId = "3f09027e-bead-438c-a97a-d9d01f8eade2",
                       UserId = "39db4566-a788-490e-b8a6-4fe9b829fcc2"
                   }
            );
            modelBuilder.Entity<GeneralConfig>().HasData(
       new GeneralConfig() { Id = 1 }
       );
        }
    }
}