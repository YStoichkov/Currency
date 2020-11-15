namespace CurrencyExchange.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CurrencyExchange.Data.Models;

    public class CurrencySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Currencies.Any())
            {
                return;
            }
            else
            {
                var currencies = new List<string> { "Euro", "Pound", "Dollar", "Frank", "Lei", "Forint", "Lira" };
                var codes = new List<string> { "EUR", "GBP", "USD", "CHF", "RON", "HUF", "TRL" };
                int count = 0;
                foreach (var currency in currencies)
                {
                    await dbContext.Currencies.AddAsync(new Currency
                    {
                        CurrencyCode = codes[count],
                        CurrencyName = currency,
                        Description = currency,
                    });
                    count++;
                }
            }
        }
    }
}
