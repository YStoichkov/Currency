namespace CurrencyExchange.Web.Controllers
{
    using CurrencyExchange.Data;
    using CurrencyExchange.Web.ViewModels.Currency;
    using Microsoft.AspNetCore.Mvc;

    public class CurrencyController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CurrencyController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Detailed()
        {
            var model = new CurrencyDetailedViewModel
            {
                Name = "Euro",
                Description = "The Currency for EU",
                BuyForPrice = 1.953M,
                SellForPrice = 1.955M,
            };
            return this.View(model);
        }
    }
}
