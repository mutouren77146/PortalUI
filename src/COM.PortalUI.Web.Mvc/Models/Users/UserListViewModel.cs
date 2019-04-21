using System.Collections.Generic;
using COM.PortalUI.Roles.Dto;
using COM.PortalUI.Users.Dto;

namespace COM.PortalUI.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
