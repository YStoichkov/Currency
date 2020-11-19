namespace CurrencyExchange.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CurrencyExchange.Data.Common.Repositories;
    using CurrencyExchange.Data.Models;
    using CurrencyExchange.Services.Mapping;

    public class CurrencyService : ICurrenciesService
    {
        private readonly IDeletableEntityRepository<Currency> currencyRepository;

        public CurrencyService(IDeletableEntityRepository<Currency> currencyRepository)
        {
            this.currencyRepository = currencyRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Currency> query = this.currencyRepository.All().OrderBy(x => x.CurrencyName);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetByName<T>(string name)
        {
            var currency = this.currencyRepository.All()
                 .Where(x => x.CurrencyName.Replace(" ", "-") == name.Replace(" ", "-"))
                 .To<T>().FirstOrDefault();
            return currency;
        }
    }
}
