using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace COM.PortalUI.Controllers
{
    public abstract class PortalUIControllerBase: AbpController
    {
        protected PortalUIControllerBase()
        {
            LocalizationSourceName = PortalUIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
