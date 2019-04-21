using Abp.Application.Services;
using Abp.Application.Services.Dto;
using COM.PortalUI.MultiTenancy.Dto;

namespace COM.PortalUI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

