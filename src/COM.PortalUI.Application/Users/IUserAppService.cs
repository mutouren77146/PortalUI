using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using COM.PortalUI.Roles.Dto;
using COM.PortalUI.Users.Dto;

namespace COM.PortalUI.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
