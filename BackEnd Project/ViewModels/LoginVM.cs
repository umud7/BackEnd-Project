﻿using System.ComponentModel.DataAnnotations;

namespace BackEnd_Project.ViewModels
{
    public class LoginVM
    {
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
