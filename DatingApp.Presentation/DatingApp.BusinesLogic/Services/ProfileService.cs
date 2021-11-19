using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateProfile(ProfileModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProfileModel,DatingApp.DataAccessLayer.Models.Profile>());
            var mapper = new Mapper(config);
            var profileBL = mapper.Map<DatingApp.DataAccessLayer.Models.Profile>(model);
            _unitOfWork.Profile.Add(profileBL);
            _unitOfWork.Save();
        }
        public List<ProfileModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DatingApp.DataAccessLayer.Models.Profile, ProfileModel>());
            var mapper = new Mapper(config);
            var profileModels = _unitOfWork.Profile.GetAll().ToList();
            var result = profileModels.Select(p => mapper.Map<ProfileModel>(p)).ToList();

            return result;
        }

        public ProfileModel GetById(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DatingApp.DataAccessLayer.Models.Profile, ProfileModel>()
            .ForMember(x=> x.City, y => y.MapFrom(p => _unitOfWork.LookupValue.Get().FirstOrDefault(z=>z.Id == p.CityId).Title)));
            var mapper = new Mapper(config);
            var profile = _unitOfWork.Profile.Get(x => x.Id == id).FirstOrDefault();
            if (profile != null)
                return mapper.Map<ProfileModel>(profile);
            else
                return null;
        }
    }
}
