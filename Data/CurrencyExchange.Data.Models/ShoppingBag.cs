namespace CurrencyExchange.Data.Models
{
    public class ShoppingBag
    {
         // TODO
        public string Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser Client { get; set; }
    }
}
