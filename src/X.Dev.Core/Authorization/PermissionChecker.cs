using Abp.Authorization;
using X.Dev.Authorization.Roles;
using X.Dev.Authorization.Users;

namespace X.Dev.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
