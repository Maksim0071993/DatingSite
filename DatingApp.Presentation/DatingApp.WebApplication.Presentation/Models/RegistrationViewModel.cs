using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Models
{
    public class RegistrationViewModel
    {
        public string Email { get; set; }    
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
