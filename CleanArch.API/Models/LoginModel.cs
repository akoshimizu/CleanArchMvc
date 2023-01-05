﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CleanArch.API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid format email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage = "The{0} mus be at least {2} and at max {1} characters long", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
