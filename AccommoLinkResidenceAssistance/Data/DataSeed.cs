using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Constants;
using Microsoft.AspNetCore.Identity;

namespace AccommoLinkResidenceAssistance.Data
{
    public class DataSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Admin));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Student));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.University));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Landlord));
        }
    }
}
