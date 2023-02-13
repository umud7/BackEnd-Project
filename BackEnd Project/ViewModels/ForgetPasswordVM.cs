using BackEnd_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace BackEnd_Project.ViewModels
{
    public class ForgetPasswordVM
    {
        public AppUser appUser { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
