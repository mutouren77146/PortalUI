using Microsoft.AspNetCore.Antiforgery;
using COM.PortalUI.Controllers;

namespace COM.PortalUI.Web.Host.Controllers
{
    public class AntiForgeryController : PortalUIControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
