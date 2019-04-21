using System.Collections.Generic;
using System.Linq;
using COM.PortalUI.Roles.Dto;
using COM.PortalUI.Users.Dto;

namespace COM.PortalUI.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
