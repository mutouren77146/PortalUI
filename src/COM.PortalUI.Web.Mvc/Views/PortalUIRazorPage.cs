using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace COM.PortalUI.Web.Views
{
    public abstract class PortalUIRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PortalUIRazorPage()
        {
            LocalizationSourceName = PortalUIConsts.LocalizationSourceName;
        }
    }
}
