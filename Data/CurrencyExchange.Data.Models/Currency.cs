namespace CurrencyExchange.Data.Models
{
    using CurrencyExchange.Data.Common.Models;

    public class Currency : BaseDeletableModel<string>
    {
        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public int Quantity { get; set; }

        public decimal BuyForPrice { get; set; }

        public decimal SellForPrice { get; set; }

        public string Description { get; set; }
    }
}
