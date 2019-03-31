using System.Collections.Generic;
using X.Dev.Roles.Dto;
using X.Dev.Users.Dto;

namespace X.Dev.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}