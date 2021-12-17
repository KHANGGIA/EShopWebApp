using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SharedObject.Common;
namespace EShopAPI.Model.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
              new AppConfig() { Key = "HomeTitle", Value = " This is Home Page of EShopWebSolution" },
              new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword of EShopWebSolution" },
              new AppConfig() { Key = "HomeDescription", Value = "This is description of EShopWebSolution" }
              );
            modelBuilder.Entity<Language>().HasData(
              new Language() { LanguageID = "en", Name = "English", IsDefault = Confirm.Yes },
              new Language() { LanguageID = "vi", Name = "Tiếng Việt", IsDefault = Confirm.No});

            // any guid
            var roleId = new Guid("E2AEABA0-2BFE-480F-B4A9-BBB151B4A7D7");
            var adminId = new Guid("C2EEE4A8-973C-4EFE-806F-78E9D2E09CFC");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "khanggiavu250296@gmail.com",
                NormalizedEmail = "khanggiavu250296@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null,"Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Khang",
                LastName = "Vu",
                DOB = new DateTime(1996,02,25),
                Address ="57A Đường 29 Khu Phố 2 Linh Đông TP.Thủ Đức",
                CreateDate = new DateTime(2021,12,17),
                LastLogin = new DateTime(2021,12,17),
                LoginStatus = Status.Active
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
