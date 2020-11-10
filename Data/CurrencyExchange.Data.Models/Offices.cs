namespace CurrencyExchange.Data.Models
{
    using CurrencyExchange.Data.Common.Models;

    public class Offices : BaseDeletableModel<string>
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
