using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(225)]
        public string Username { get; set; }
        [Required]
        [StringLength(225)]

        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
