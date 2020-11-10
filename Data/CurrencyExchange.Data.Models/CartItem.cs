namespace CurrencyExchange.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using CurrencyExchange.Data.Common.Models;

    public class CartItem : BaseDeletableModel<string>
    {
        [Key]
        public string IdemId { get; set; }

        public string CardId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public Gold GoldProduct { get; set; }
    }
}
