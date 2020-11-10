namespace CurrencyExchange.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class GoldController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
