using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class RegistrationUser
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
