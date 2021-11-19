
using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
               
        public RegistrationModel SearchUser(string email, string password)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RegistrationUser, RegistrationModel>());
            var mapper = new Mapper(config);
            var user = _unitOfWork.Registration.Get(x => x.Email == email && x.UserPassword.TrimEnd() == password).FirstOrDefault();
            RegistrationModel result = null;
            if (user != null)
            {
                result = mapper.Map<RegistrationModel>(user);
            }
            return result;
        }
    }
}
