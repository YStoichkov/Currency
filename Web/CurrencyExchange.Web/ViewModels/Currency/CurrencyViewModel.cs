namespace CurrencyExchange.Web.ViewModels.Currency
{
    public class CurrencyViewModel
    {
        public string Id { get; set; }

        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public int Quantity { get; set; }

        public decimal BuyForPrice { get; set; }

        public decimal SellForPrice { get; set; }
    }
}
