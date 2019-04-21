using Abp.AutoMapper;
using COM.PortalUI.Sessions.Dto;

namespace COM.PortalUI.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
