using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace Hanover.UmbracoEndpointBuilders
{
    public static class UmbracoEndpointBuilder
    {
        public static IUmbracoEndpointBuilderContext UseCustomRouting(this IUmbracoEndpointBuilderContext context)
        {
            if (!context.RuntimeState.UmbracoCanBoot())
                return context;

            context.EndpointRouteBuilder.MapControllerRoute(
                    "Admin",
                    "umbraco/backoffice/Contact",
                    new { Controller = "Contact", Action = "Index" }
                );

            return context;
        }
    }
}
