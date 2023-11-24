namespace NonProfitLibrary.Data;

 public static class ModelBuilderExtensions 
    {
    public static void Seed(this ModelBuilder builder) 
    {
        var pwd = "P@$$w0rd";
        var passwordHasher = new PasswordHasher<IdentityUser>();

        // Seed Roles
        var adminRole = new IdentityRole("Admin");
        adminRole.NormalizedName = adminRole.Name?.ToUpper();

        var financeRole = new IdentityRole("Finance");
        financeRole.NormalizedName = financeRole.Name?.ToUpper();

        List<IdentityRole> roles = new List<IdentityRole>() {
           adminRole,
           financeRole
        };

        // here roles are added to the database
        builder.Entity<IdentityRole>().HasData(roles);

         
        // Seed Users
        var adminUser = new IdentityUser {
            UserName = "a@a.a",
            Email = "a@a.a",
            EmailConfirmed = true,
        };
        adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
        adminUser.NormalizedEmail = adminUser.Email.ToUpper();
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

        var financeUser = new IdentityUser {
            UserName = "f@f.f",
            Email = "f@f.f",
            EmailConfirmed = true,
        };
        financeUser.NormalizedUserName = financeUser.UserName.ToUpper();
        financeUser.NormalizedEmail = financeUser.Email.ToUpper();
        financeUser.PasswordHash = passwordHasher.HashPassword(financeUser, pwd);

        List<IdentityUser> users = new List<IdentityUser>() {
           adminUser,
           financeUser,
        };

        // here users are added to the database
        builder.Entity<IdentityUser>().HasData(users);

        // Seed UserRoles
        List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

        userRoles.Add(new IdentityUserRole<string> {
            UserId = users[0].Id,
            RoleId = roles.First(q => q.Name == "Admin").Id
        });

        userRoles.Add(new IdentityUserRole<string> {
            UserId = users[1].Id,
            RoleId = roles.First(q => q.Name == "Finance").Id
        });

        // here userRoles are added to the database
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    }
}