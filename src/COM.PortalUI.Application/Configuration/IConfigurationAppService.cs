using System.Threading.Tasks;
using COM.PortalUI.Configuration.Dto;

namespace COM.PortalUI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
