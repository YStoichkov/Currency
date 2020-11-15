namespace CurrencyExchange.Services.Data
{
    using System.Collections.Generic;

    public interface ICurrencyService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);
    }
}
