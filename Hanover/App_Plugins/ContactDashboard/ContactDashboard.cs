using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Dashboards;

namespace Hanover.App_Plugins.ContactDashboard
{
    public class ContactDashboard : IDashboard
    {
        public string[] Sections => new[] { Constants.Applications.Content };

        public IAccessRule[] AccessRules
        {
            get
            {
                return new IAccessRule[]
                {
                    new AccessRule { Type = AccessRuleType.Grant, Value = Constants.Security.EditorGroupAlias},
                    new AccessRule { Type = AccessRuleType.Grant, Value = Constants.Security.AdminGroupAlias}
                };
            }
        }

        public string? Alias => "Contact";

        public string? View => "backoffice/Contact";
    }
}
