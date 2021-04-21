using Abp.Authorization;
using Test.MyProject.Authorization.Roles;
using Test.MyProject.Authorization.Users;

namespace Test.MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
