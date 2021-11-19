using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.BusinessModel
{
    public class RegistrationModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public virtual ProfileModel Profile { get; set; }
    }
}
