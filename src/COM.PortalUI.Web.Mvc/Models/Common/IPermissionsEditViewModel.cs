using System.Collections.Generic;
using COM.PortalUI.Roles.Dto;

namespace COM.PortalUI.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}