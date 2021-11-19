using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.Common;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace DatingApp.BusinesLogic.Services
{
    public class SearchService : ISearchService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SearchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<ProfileModel> SearchUserToProfile(string firstName, int? ageFrom, int? ageTo, int cityId, Sex? sex, Orientations? orientation)
        {
            var profiles = _unitOfWork.Profile.Get();            

            if (firstName != null)
            {
                profiles = profiles.Where(p => p.FirstName.Contains(firstName));
            }

            if (ageFrom != 0 && ageTo == 0)
            {
                profiles = profiles.Where(p => p.Age >= ageFrom);
            }
            else if (ageFrom == 0 && ageTo != 0)
            {
                profiles = profiles.Where(p => p.Age <= ageTo);
            }
            else if (ageFrom != 0 && ageTo != 0)
            {
                profiles = profiles.Where(p => p.Age >= ageFrom && p.Age <= ageTo);
            }

            if (cityId != 0)
            {
                profiles = profiles.Where(p => p.CityId == cityId);
            }

            if ((int)sex != -1)
            {
                profiles = profiles.Where(p => p.Sex == sex);
            }

            if ((int)orientation != -1)
            {
                profiles = profiles.Where(p => p.Orientation == orientation);
            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DatingApp.DataAccessLayer.Models.Profile, ProfileModel>());
            var mapper = new Mapper(config);
            var result = profiles.Select(p => mapper.Map<ProfileModel>(p)).ToList();
            return result;
        }
    }
}
