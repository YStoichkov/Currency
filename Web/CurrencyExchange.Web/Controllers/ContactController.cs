namespace CurrencyExchange.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Success()
        {
            return this.View();
        }
    }
}
