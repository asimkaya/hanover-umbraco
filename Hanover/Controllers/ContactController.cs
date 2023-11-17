using Hanover.Data;
using Hanover.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;
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
            var reCaptchaResult = Verify(Request.Form["g-Recaptcha-Response"]);
            if (!ModelState.IsValid)
            {
                TempData["ContactSuccess"] = false;
                return CurrentUmbracoPage();
            }
            if (!reCaptchaResult.Success)
            {
                TempData["ContactSuccess"] = false;
                return CurrentUmbracoPage();
            }

            Guid guid = Guid.NewGuid();
            model.Id = guid;
            model.CreateDate = DateTime.Now;

            _dataContext.ContactModel.Add(model);
            _dataContext.SaveChanges();
            TempData["ContactSuccess"] = true;
            SendEmail(model);


            return RedirectToCurrentUmbracoPage();
        }

        public ReCaptchaResult Verify(string reCaptchaResponse)
        {
            using var client = new WebClient();
            var response = client.DownloadString($"https://www.google.com/recaptcha/api/siteverify?secret={_configuration["ReCaptcha:SecretKey"]}&response={reCaptchaResponse}");

            return JsonConvert.DeserializeObject<ReCaptchaResult>(response);
        }

        private void SendEmail(ContactModel model)
        {
            var message = new MailMessage(_configuration["EmailConfiguration:From"], "enq@hanover71suites.com")
            {
                IsBodyHtml = true
            };

            message.Subject = "Hanover Contact Form";

            message.Body = string.Format(@"Ad: {0} <br/>
                             Telefon: {1} <br/>
                             E-Posta: {2} <br/>
                             Mesaj: {3}",
                model.Name,
                model.Phone,
                model.Email,
                model.Message);

            var client = new SmtpClient(_configuration["EmailConfiguration:SmtpAddress"], Convert.ToInt32(_configuration["EmailConfiguration:SmtpPort"]));
            client.EnableSsl = Convert.ToBoolean(_configuration["EmailConfiguration:EnableSsl"]);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_configuration["EmailConfiguration:Username"], _configuration["EmailConfiguration:Password"]);
            client.Send(message);
        }
    }
}
