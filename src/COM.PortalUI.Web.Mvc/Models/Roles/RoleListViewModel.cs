using System.Collections.Generic;
using COM.PortalUI.Roles.Dto;

namespace COM.PortalUI.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
