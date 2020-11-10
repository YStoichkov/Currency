namespace CurrencyExchange.Web.ViewModels.Currency
{
    public class CurrencyDetailedViewModel
    {
        public string Id { get; set; }

        public string Flag { get; set; }

        public string Name { get; set; }

        public string CurrencyCode { get; set; }

        public decimal BuyForPrice { get; set; }

        public decimal SellForPrice { get; set; }

        public string Description { get; set; }
    }
}
