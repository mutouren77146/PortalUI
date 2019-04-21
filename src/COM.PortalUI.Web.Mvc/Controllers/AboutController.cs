using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using COM.PortalUI.Controllers;

namespace COM.PortalUI.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PortalUIControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
