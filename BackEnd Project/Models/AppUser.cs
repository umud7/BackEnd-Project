using Microsoft.AspNetCore.Identity;

namespace BackEnd_Project.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
