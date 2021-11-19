using DatingApp.BusinesLogic.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface IUserService
    {
        RegistrationModel SearchUser(string email, string password);
    }
}
