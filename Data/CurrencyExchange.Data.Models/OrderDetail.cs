namespace CurrencyExchange.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public int GoldId { get; set; }

        public virtual Gold Gold { get; set; }

        public int SilverId { get; set; }

        public virtual Silver Silver { get; set; }

        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Order Order { get; set; }
    }
}
