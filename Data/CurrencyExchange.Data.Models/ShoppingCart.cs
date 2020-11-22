namespace CurrencyExchange.Data.Models
{
    using System.Collections.Generic;

    using CurrencyExchange.Data.Common.Models;

    public class ShoppingCart : BaseDeletableModel<int>
    {
        public IEnumerable<ShoppingCartItem> ShoppinhCartItems { get; set; }
    }
}
