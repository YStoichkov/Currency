namespace CurrencyExchange.Data.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public Gold Gold { get; set; }

        public Silver Silver { get; set; }

        public Currency Currency { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
