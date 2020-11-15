namespace CurrencyExchange.Data.Models
{
    using CurrencyExchange.Data.Common.Models;
    using CurrencyExchange.Data.Models.Enum;

    public class Job : BaseDeletableModel<string>
    {
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public decimal? Salary { get; set; }

        public Category Category { get; set; }
    }
}
