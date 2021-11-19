using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface ISearchService
    {
        public List<ProfileModel> SearchUserToProfile(string firstName, int? ageFrom, int? ageTo, int cityId, Sex? sex, Orientations? orientation);

    }
}
