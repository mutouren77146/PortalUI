using System.Threading.Tasks;
using Abp.Application.Services;
using COM.PortalUI.Sessions.Dto;

namespace COM.PortalUI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
