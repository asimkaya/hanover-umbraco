using Hanover.Data;
using Hanover.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Hanover.Controllers
{
    public class ContactController : SurfaceController
    {
        private readonly IConfiguration _configuration;
        private readonly DataContext _dataContext;

        public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, IConfiguration configuration, DataContext dataContext) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _configuration = configuration;
            _dataContext = dataContext;
        }

        [HttpPost]
        public IActionResult Submit(ContactModel model)
        {
            if(!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            Guid guid = Guid.NewGuid();
            model.Id = guid;
            model.CreateDate = DateTime.Now;

            _dataContext.ContactModel.Add(model);
            _dataContext.SaveChanges();
            TempData["ContactSuccess"] = true;


            return RedirectToCurrentUmbracoPage();
        }
    }
}
