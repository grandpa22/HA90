using Abp.Authorization;
using ArtmisNet.Ha90.Authorization.Roles;
using ArtmisNet.Ha90.Authorization.Users;

namespace ArtmisNet.Ha90.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
