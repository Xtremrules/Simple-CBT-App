﻿using System.ComponentModel.DataAnnotations;

namespace CBT.WebUI.Models
{
    public class LoginViewModel
    {
        [Required, Display(Name = "Username")]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}