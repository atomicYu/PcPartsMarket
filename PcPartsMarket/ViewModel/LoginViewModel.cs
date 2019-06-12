using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter the User Name.")]
        [StringLength(50, ErrorMessage = "The User Name must be less than {1} characters.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 7)]       
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
