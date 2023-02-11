using System.ComponentModel.DataAnnotations;

namespace BackEnd_Project.ViewModels
{
    public class RegisterVM
    {
        [Required, MinLength(2)]

        public string FullName { get; set; }
        [Required, MinLength(2)]
        public string UserName { get; set; }
        [Required, EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}
