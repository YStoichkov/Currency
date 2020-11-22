namespace CurrencyExchange.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // private readonly RoleManager<ApplicationRole> roleManager;
        // private readonly UserManager<ApplicationUser> userManager;
        // [Authorize(Roles = "Admin" , "Dealer")]
        // public async Task<IActionResult> ChangeCurrencyDate()
        // {
        //    if (!await this.roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await this.roleManager.CreateAsync(new IdentityRole
        //        {
        //            Name = "Admin",
        //        });
        //    }

        // var user = await this.userManager.GetUserAsync(this.User);
        //    var result = this.userManager.AddToRoleAsync(user, "Admin");
        //    return this.Json(result);
        // }
    }
}
