using Abp.AutoMapper;
using COM.PortalUI.Authentication.External;

namespace COM.PortalUI.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
