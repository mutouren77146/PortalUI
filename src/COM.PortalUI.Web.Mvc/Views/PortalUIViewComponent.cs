using Abp.AspNetCore.Mvc.ViewComponents;

namespace COM.PortalUI.Web.Views
{
    public abstract class PortalUIViewComponent : AbpViewComponent
    {
        protected PortalUIViewComponent()
        {
            LocalizationSourceName = PortalUIConsts.LocalizationSourceName;
        }
    }
}
