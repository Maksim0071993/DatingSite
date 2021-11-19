using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface IRegistrationService
    {
        public int Register(string email, string password);
        public bool EmailVerifaction(string email);
    }
}
