namespace CurrencyExchange.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SilverController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
