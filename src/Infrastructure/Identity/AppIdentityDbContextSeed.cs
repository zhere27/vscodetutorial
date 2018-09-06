using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "zhere27@gmail.com", Email = "zhere27@gmail.com" };
            await userManager.CreateAsync(defaultUser, "P@$$w0rd");
        }
    }
}
