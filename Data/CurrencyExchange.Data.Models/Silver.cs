namespace CurrencyExchange.Data.Models
{
    using CurrencyExchange.Data.Common.Models;

    public class Silver : BaseDeletableModel<string>
    {
        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public decimal BuyForPrice { get; set; }

        public decimal SellForPrice { get; set; }

        public int AvailableQuantity { get; set; }
    }
}
