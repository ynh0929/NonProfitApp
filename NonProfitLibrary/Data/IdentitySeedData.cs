namespace NonProfitLibrary.Data
{
    public class IdentitySeedData 
    {
    public static async Task Initialize(AppDbContext context,
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager) {

        context.Database.EnsureCreated();

        string adminRole = "Admin";
        string financeRole = "Finance";
        string password4all = "P@$$w0rd";

        if (await roleManager.FindByNameAsync(adminRole) == null) {
            await roleManager.CreateAsync(new IdentityRole(adminRole));
        }

        if (await roleManager.FindByNameAsync(financeRole) == null) {
            await roleManager.CreateAsync(new IdentityRole(financeRole));
        }

        if (await userManager.FindByNameAsync("a@a.a") == null){
            var user = new IdentityUser {
                UserName = "a@a.a",
                Email = "a@a.a"
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password4all);
                await userManager.AddToRoleAsync(user, adminRole);
            }
        }

        if (await userManager.FindByNameAsync("bb@bb.bb") == null) {
            var user = new IdentityUser {
                UserName = "bb@bb.bb",
                Email = "bb@bb.bb",
                PhoneNumber = "7788951456"
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password4all);
                await userManager.AddToRoleAsync(user, adminRole);
            }
        }

        if (await userManager.FindByNameAsync("mm@mm.mm") == null) {
            var user = new IdentityUser {
                UserName = "f@f.f",
                Email = "f@f.f"
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password4all);
                await userManager.AddToRoleAsync(user, financeRole);
            }
        }

        if (await userManager.FindByNameAsync("dd@dd.dd") == null) {
            var user = new IdentityUser {
                UserName = "dd@dd.dd",
                Email = "dd@dd.dd"
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password4all);
                await userManager.AddToRoleAsync(user, financeRole);
            }
        }
    }
}
}