namespace CurrencyExchange.Data.Models
{
    using CurrencyExchange.Data.Common.Models;

    public class ContactForm : BaseDeletableModel<string>
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Question { get; set; }

        public bool IsAnswered { get; set; }
    }
}
