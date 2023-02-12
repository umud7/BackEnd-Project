using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BackEnd_Project.ViewModels
{
    public class RoleVM
    {
        public List<IdentityRole> Roles { get; set; }
        public IList<string> UserRoles { get; set; }
        public string UserId { get; set; }
        public string FullName  { get; set; }
    }
}
