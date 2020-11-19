namespace CurrencyExchange.Web.Controllers
{
    using System.Linq;

    using CurrencyExchange.Data;
    using CurrencyExchange.Services.Data;
    using CurrencyExchange.Web.ViewModels.Currency;
    using Microsoft.AspNetCore.Mvc;

    public class CurrencyController : BaseController
    {
        private readonly ICurrenciesService currencyService;

        public CurrencyController(ICurrenciesService currencyService)
        {
            this.currencyService = currencyService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var currencies = this.currencyService.GetAll<IndexCurrencyViewModel>();
            viewModel.Currencies = currencies;
            return this.View(viewModel);
        }

        public IActionResult Detailed(string name)
        {
            var viewModel =
                this.currencyService.GetByName<IndexCurrencyViewModel>(name);
            return this.View(viewModel);
        }
    }
}
