using System.Threading.Tasks;
using Abp.Application.Services;
using COM.PortalUI.Authorization.Accounts.Dto;

namespace COM.PortalUI.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
