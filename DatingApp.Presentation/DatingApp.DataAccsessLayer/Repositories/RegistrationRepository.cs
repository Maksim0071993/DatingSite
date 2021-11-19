using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories
{
   public class RegistrationRepository : IRegistrationRepository
    {
        private readonly DatingAppWinFormsContext _datingAppWinFormsContext;

        public RegistrationRepository(DatingAppWinFormsContext datingAppWinFormsContext)
        {
            _datingAppWinFormsContext = datingAppWinFormsContext;
        }

        public void Add(RegistrationUser registrationUser)
        {
            _datingAppWinFormsContext.RegistrationUsers.Add(registrationUser);
        }
        public List<RegistrationUser> Get(Func<RegistrationUser, bool> func)
        {
            var registrationUsers = _datingAppWinFormsContext.RegistrationUsers.Where(func).ToList();
            return registrationUsers;
        }
    }
}