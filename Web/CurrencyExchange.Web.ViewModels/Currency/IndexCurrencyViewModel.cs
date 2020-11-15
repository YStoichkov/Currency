namespace CurrencyExchange.Web.ViewModels.Currency
{
    using CurrencyExchange.Data.Models;
    using CurrencyExchange.Services.Mapping;

    public class IndexCurrencyViewModel : IMapFrom<Currency>
    {
        public int Id { get; set; }

        public string CurrencyImage { get; set; }

        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public int Quantity { get; set; }

        public decimal BuyForPrice { get; set; }

        public decimal SellForPrice { get; set; }

        public string Description { get; set; }

        public string Url => $"/Currency/{this.CurrencyName.Replace(' ', '-')}";
    }
}
