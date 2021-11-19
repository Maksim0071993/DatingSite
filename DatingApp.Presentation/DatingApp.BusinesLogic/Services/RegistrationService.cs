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
    public class RegistrationService : IRegistrationService
    {

        private readonly IUnitOfWork _unitOfWork;
        public RegistrationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Register(string email, string password)
        {    
            RegistrationModel _registrationUsers = new RegistrationModel()
            {
                Email = email,
                UserPassword = password
            };
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RegistrationModel, RegistrationUser>());
            var mapper = new Mapper(config);
            var registrationUserDLL = mapper.Map<RegistrationUser>(_registrationUsers);
            _unitOfWork.Registration.Add(registrationUserDLL);
            _unitOfWork.Save();
            return registrationUserDLL.UserId;
        }

        public bool EmailVerifaction(string email)
        {
            var user = _unitOfWork.Registration.Get(x => x.Email == email).FirstOrDefault();
            bool result;
            if(user != null)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
