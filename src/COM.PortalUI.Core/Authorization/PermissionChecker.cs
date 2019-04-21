using Abp.Authorization;
using COM.PortalUI.Authorization.Roles;
using COM.PortalUI.Authorization.Users;

namespace COM.PortalUI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
