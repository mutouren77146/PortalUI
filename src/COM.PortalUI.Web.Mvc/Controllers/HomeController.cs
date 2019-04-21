using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using COM.PortalUI.Controllers;

namespace COM.PortalUI.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PortalUIControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
