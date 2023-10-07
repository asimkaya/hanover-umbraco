using Hanover.Data;
using Hanover.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Authorization;
using Umbraco.Cms.Web.Common.Filters;

namespace Hanover.App_Plugins.ContactDashboard
{
    [Authorize(Policy = AuthorizationPolicies.BackOfficeAccess)]
    [DisableBrowserCache]
    public class ContactController : Controller
    {
        private readonly DataContext _dataContext;
        public ContactController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            IEnumerable<ContactModel> contacts = _dataContext.ContactModel.AsQueryable().OrderBy(x => x.CreateDate).ToList();
            return View(contacts);
        }
    }
}
