namespace CurrencyExchange.Web.Areas.Administration.Controllers
{
    using CurrencyExchange.Common;
    using CurrencyExchange.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
