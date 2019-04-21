using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using COM.PortalUI.Configuration.Dto;

namespace COM.PortalUI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PortalUIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
